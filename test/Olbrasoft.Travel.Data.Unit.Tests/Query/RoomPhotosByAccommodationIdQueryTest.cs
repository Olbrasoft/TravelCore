﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using Olbrasoft.Data.Queries;
using Olbrasoft.Travel.Data.Query;

namespace Olbrasoft.Travel.Data.Unit.Tests.Query
{
    [TestFixture]
    internal class RoomPhotosByAccommodationIdQueryTest
    {
        
        [Test]
        public void Instance_Is_ByAccommodationIdQuery_Of_IEnumerable_Of_RoomPhoto()
        {
            //Arrange
            var type = typeof(ByAccommodationIdQuery<IEnumerable<RoomPhoto>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type,query);

        }

        [Test]
        public void Instance_Implement_Interface_IQuery()
        {
            //Arrange
            var type = typeof(IQuery<IEnumerable<RoomPhoto>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        private static RoomPhotosByAccommodationIdQuery Query()
        {
            var providerMock = new Mock<IProvider>();

            //Act
            var query = new RoomPhotosByAccommodationIdQuery(providerMock.Object);
            return query;
        }

        [Test]
        public void Instance_Implement_Interface_IHaveAccommodationId()
        {
            //Arrange
            var providerMock = new Mock<IProvider>();

            //Act
            var query = new RoomPhotosByAccommodationIdQuery(providerMock.Object);

            //Assert
            Assert.IsInstanceOf<IHaveAccommodationId>(query);
        }
    }
}