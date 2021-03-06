﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.EntityTypesConfigurations.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.EntityTypesConfigurations.Property
{
    [TestFixture]
    internal class TypeOfDescriptionConfigurationTest
    {
        [Test]
        public void Instance_Is_NameConfiguration_Of_TypeOfDescription()
        {
            //Arrange
            var type = typeof(NameAccommodationTypeConfiguration<Description>);

            //Act
            var configuration = new DescriptionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}