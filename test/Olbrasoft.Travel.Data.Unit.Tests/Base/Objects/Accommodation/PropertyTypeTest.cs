﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Base.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.Unit.Tests.Base.Objects.Accommodation
{
    public class PropertyTypeTest
    {
        [Test]
        public void LocalizedPropertyTypes()
        {
            //Arrange
            var localizedRealEstateTypes = new[] { new PropertyTypeTranslation() };

            //Act
            var realEstateType = new PropertyType
            {
                PropertyTypesTranslations = localizedRealEstateTypes
            };

            //Assert
            Assert.AreSame(localizedRealEstateTypes, realEstateType.PropertyTypesTranslations);
        }
    }
}