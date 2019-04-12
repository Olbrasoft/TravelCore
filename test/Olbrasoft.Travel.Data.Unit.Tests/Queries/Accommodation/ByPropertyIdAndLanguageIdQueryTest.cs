﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Querying;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Queries.Accommodation;

namespace Olbrasoft.Travel.Data.Unit.Tests.Queries.Accommodation
{
    [TestFixture]
    internal class ByPropertyIdAndLanguageIdQueryTest
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
        public void ExampleByAccommodationIdAndLanguageIdQuery_Inherits_From_ByAccommodationIdAndLanguageIdQuery_Of_object()
        {
            //Arrange
            var type = typeof(ByPropertyIdAndLanguageIdQuery<object>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        private static AwesomeByPropertyIdAndLanguageIdQuery Query()
        {
            var providerMock = new Mock<IQueryDispatcher>();
            return new AwesomeByPropertyIdAndLanguageIdQuery(providerMock.Object);
        }

        [Test]
        public void Inherits_From_ByLanguageIdQuery()
        {
            //Arrange
            var type = typeof(TranslationQuery<object>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void AccommodationId_Get_Set()
        {
            //Arrange
            const int accommodationId = int.MaxValue;
            var query = Query();

            //Act
            query.PropertyId = accommodationId;

            //Assert
            Assert.IsTrue(query.PropertyId == accommodationId);
        }
    }
}