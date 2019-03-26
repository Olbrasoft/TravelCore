﻿using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Querying;
using Olbrasoft.Globalization;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Queries.Accommodation;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Data.Unit.Tests.Queries.Accommodation
{
    [TestFixture]
    internal class RoomsByAccommodationIdAndLanguageIdQueryTest
    {
        [Test]
        public void Instance_Is_ByAccommodationIdAndLanguageIdQuery_Of_IEnumerable_OfRoom()
        {
            //Arrange
            var type = typeof(ByRealEstateIdAndLanguageIdQuery<IEnumerable<Room>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_Is_ByLanguageIdQuery_Of_IEnumerable_Of_Room()
        {
            //Arrange
            var type = typeof(ByLanguageIdQuery<IEnumerable<Room>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_Implement_Interface_IQueryOfRoom()
        {
            //Arrange
            var type = typeof(IQuery<IEnumerable<Room>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveLanguageIdOfInteger()
        {
            //Arrange
            var type = typeof(IHaveLanguageId<int>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveAccommodationId()
        {
            //Arrange
            var type = typeof(IHaveAccommodationId);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        private static RoomsByRealEstateIdAndLanguageIdQuery Query()
        {
            var providerMock = new Mock<IQueryDispatcher>();
            return new RoomsByRealEstateIdAndLanguageIdQuery(providerMock.Object);
        }
    }
}