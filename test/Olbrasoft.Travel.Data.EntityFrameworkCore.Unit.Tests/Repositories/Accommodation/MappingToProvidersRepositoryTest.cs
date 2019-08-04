﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Base.Objects.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Repositories;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Repositories.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.Repositories.Accommodation
{
    [TestFixture]
    internal class MappingToProvidersRepositoryTest
    {
        [Test]
        public void Instance_Is_PropertyRepository_Of_TypeOfAccommodation()
        {
            //Arrange
            var type = typeof(TravelRepository<PropertyType>);
            var contextMock = new Mock<TravelDbContext>();

            //Act
            var repository = new MappingToProvidersRepository<PropertyType>(contextMock.Object);

            //Assert
            Assert.IsInstanceOf(type, repository);
        }
    }
}