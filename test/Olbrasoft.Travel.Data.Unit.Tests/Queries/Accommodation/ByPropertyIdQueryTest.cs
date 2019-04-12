﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Querying;

namespace Olbrasoft.Travel.Data.Unit.Tests.Queries.Accommodation
{
    [TestFixture]
    internal class ByPropertyIdQueryTest
    {
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

        [Test]
        public void Instance_QueryWithDependentProvider_Of_object()
        {
            //Arrange
            var type = typeof(Query<object>);

            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void AccommodationId_Get_Set()
        {
            //Arrange
            const int accommodationId = int.MinValue;
            var query = Query();

            //Act
            query.PropertyId = accommodationId;

            //Assert
            Assert.IsTrue(query.PropertyId == accommodationId);
        }

        private static AwesomePropertyQuery Query()
        {
            var providerMock = new Mock<IQueryDispatcher>();

            //Act
            var query = new AwesomePropertyQuery(providerMock.Object);
            return query;
        }
    }
}