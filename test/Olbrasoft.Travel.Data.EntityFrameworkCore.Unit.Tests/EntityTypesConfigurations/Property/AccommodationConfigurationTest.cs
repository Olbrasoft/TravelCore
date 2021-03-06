﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.EntityTypesConfigurations;
using Olbrasoft.Travel.Data.EntityFrameworkCore.EntityTypesConfigurations.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.EntityTypesConfigurations.Property
{
    [TestFixture]
    internal class AccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_TravelTypeConfiguration_Of_Accommodation()
        {
            //Arrange
            var type = typeof(TravelTypeConfiguration<RealEstate>);

            //Act
            var configuration = new RealEstateConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}