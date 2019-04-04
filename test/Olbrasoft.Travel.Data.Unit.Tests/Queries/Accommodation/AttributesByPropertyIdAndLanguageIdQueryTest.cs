﻿using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Querying;
using Olbrasoft.Globalization;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Queries.Accommodation;
using Olbrasoft.Travel.Data.Transfer.Objects;
using Olbrasoft.Travel.Data.Transfer.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.Unit.Tests.Queries.Accommodation
{
    internal class AttributesByPropertyIdAndLanguageIdQueryTest
    {
        [Test]
        public void Instance_Is_ByAccommodationIdAndLanguageIdQuery_Of_IEnumerable_Of_Attribute()
        {
            //Arrange
            var type = typeof(ByPropertyIdAndLanguageIdQuery<IEnumerable<AttributeDto>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_is_ByLanguageIdQuery_Of_IEnumerable_Of_Attribute()
        {
            //Arrange
            var type = typeof(TranslationQuery<IEnumerable<AttributeDto>>);

            //Act
            var query = Query();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        private static AttributesByPropertyIdAndLanguageIdQuery Query()
        {
            var providerMock = new Mock<IQueryDispatcher>();

            //Act
            var query = new AttributesByPropertyIdAndLanguageIdQuery(providerMock.Object);
            return query;
        }

        [Test]
        public void Instance_Implement_Interface_IQuery_Of_IEnumerable_Of_Attributes()
        {
            //Arrange
            var type = typeof(IQuery<IEnumerable<AttributeDto>>);
            var providerMock = new Mock<IQueryDispatcher>();

            //Act
            var query = new AttributesByPropertyIdAndLanguageIdQuery(providerMock.Object);

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveAccommodationId()
        {
            //Arrange
            var type = typeof(IHaveAccommodationId);
            var providerMock = new Mock<IQueryDispatcher>();

            //Act
            var query = new AttributesByPropertyIdAndLanguageIdQuery(providerMock.Object);

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void AccommodationId_Get_Set()
        {
            //Arrange
            const int accommodationId = int.MaxValue;
            var providerMock = new Mock<IQueryDispatcher>();

            var query = new AttributesByPropertyIdAndLanguageIdQuery(providerMock.Object)
            {
                PropertyId = accommodationId
            };

            //Act
            var result = query.PropertyId;

            //Assert
            Assert.IsTrue(result == accommodationId);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveLanguageId_Of_Integer()
        {
            //Arrange
            var type = typeof(IHaveLanguageId<int>);
            var providerMock = new Mock<IQueryDispatcher>();

            //Act
            var query = new AttributesByPropertyIdAndLanguageIdQuery(providerMock.Object);

            //Assert
            Assert.IsInstanceOf(type, query);
        }
    }
}