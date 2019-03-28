﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.Configurations.Accommodation
{
    [TestFixture]
    internal class LocalizedRealEstateCategoryConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedTypeOfAccommodation()
        {
            //Arrange
            var type = typeof(TravelTypeConfiguration<LocalizedRealEstateCategory>);

            //Act
            var configuration = new LocalizedRealEstateCategoryConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}