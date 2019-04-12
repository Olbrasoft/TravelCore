﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.Configurations.Property
{
    [TestFixture]
    internal class PropertyTypeConfigurationTest
    {
        [Test]
        public void Instance_Is_TravelTypeConfiguration_Of_PropertyType()
        {
            //Arrange
            var type = typeof(TravelTypeConfiguration<PropertyType>);

            //Act
            var configuration = new PropertyTypeConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}