﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.Configurations.Property
{
    [TestFixture]
    internal class AccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_TravelTypeConfiguration_Of_Accommodation()
        {
            //Arrange
            var type = typeof(TravelTypeConfiguration<Data.Accommodation.Property>);

            //Act
            var configuration = new PropertyConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}