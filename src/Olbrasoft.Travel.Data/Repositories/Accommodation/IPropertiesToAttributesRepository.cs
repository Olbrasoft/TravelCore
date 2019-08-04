﻿using System.Collections.Generic;
using Olbrasoft.Travel.Data.Base.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.Repositories.Accommodation
{
    public interface IPropertiesToAttributesRepository : SharpRepository.Repository.ICompoundKeyRepository<PropertyToAttribute, int, int, int>
    {
        void BulkSave(IEnumerable<PropertyToAttribute> accommodationsToAttributes);
    }
}