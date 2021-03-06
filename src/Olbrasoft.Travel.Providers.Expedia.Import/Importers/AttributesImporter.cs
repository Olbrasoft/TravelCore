﻿using System;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.Repositories;
using Attribute = Olbrasoft.Travel.Data.Accommodation.Attribute;

namespace Olbrasoft.Travel.Providers.Expedia.Import.Importers
{
    internal class AttributesImporter : Importer
    {
        public AttributesImporter(IProvider provider, IRepositoryFactory repositoryFactory, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, repositoryFactory, sharedProperties, logger)
        {
        }

        private IReadOnlyDictionary<string, int> _typesOfAttributesNamesToIds;

        protected IReadOnlyDictionary<string, int> TypesOfAttributesNamesToIds
        {
            get => _typesOfAttributesNamesToIds ?? (_typesOfAttributesNamesToIds =
                       RepositoryFactory.Names<AttributeType>().NamesToIds);

            set => _typesOfAttributesNamesToIds = value;
        }

        private IReadOnlyDictionary<string, int> _subTypesOfAttributesNamesToIds;

        protected IReadOnlyDictionary<string, int> SubTypesOfAttributesNamesToIds
        {
            get => _subTypesOfAttributesNamesToIds ?? (_subTypesOfAttributesNamesToIds =
                       RepositoryFactory.Names<AttributeSubtype>().NamesToIds);

            set => _subTypesOfAttributesNamesToIds = value;
        }

        protected HashSet<Attribute> Attributes = new HashSet<Attribute>();

        protected override void RowLoaded(string[] items)
        {
            if (!TypesOfAttributesNamesToIds.TryGetValue(AdaptTypeOfAttributeName(items[3]), out var typeOfAttributeId) ||
                !SubTypesOfAttributesNamesToIds.TryGetValue(AdaptSubTypeOfAttributeName(items[4]), out var subTypeOfAttributeId) ||
                !int.TryParse(items[0], out var eanAttributeId)
                ) return;

            var attribute = new Attribute
            {
                ExpediaId = eanAttributeId,
                TypeId = typeOfAttributeId,
                SubtypeId = subTypeOfAttributeId,
                CreatorId = CreatorId
            };

            Attributes.Add(attribute);
        }

        protected static string AdaptSubTypeOfAttributeName(string subTypeAttributeName)
        {
            return subTypeAttributeName
                .Replace("PropertyAmenity", "AmenityOfAccommodation")
                .Replace("RoomAmenity", "AmenityOfRoom");
        }

        protected static string AdaptTypeOfAttributeName(string typeOfAttributeName)
        {
            return typeOfAttributeName
                .Replace("RoomAmenity", "Amenity")
                .Replace("PropertyAmenity", "Amenity");
        }

        public override void Import(string path)
        {
            LoadData(path);

            if (Attributes.Count <= 0) return;

            LogSave<Attribute>();
            RepositoryFactory.MappedProperties<Attribute>().BulkSave(Attributes);
            LogSaved<Attribute>();
        }

        public override void Dispose()
        {
            TypesOfAttributesNamesToIds = null;
            SubTypesOfAttributesNamesToIds = null;
            Attributes = null;

            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }
}