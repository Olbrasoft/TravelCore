﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entity.Framework.Query.Handler;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Linq;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Framework.Unit.Tests.Query.Handler
{
    [TestFixture]
    internal class PagedAccommodationItemsByLanguageIdQueryHandlerTest
    {
        [Test]
        public void Inherits_From_TravelQueryHandler_Of_IPropertyContext_Comma_PagedAccommodationItemsByLanguageIdQuery_Comma_IQueryable_Of_Accommodation_Comma_IResultWithTotalCount_Of_AccommodationItem()
        {
            //Arrange
            var type =
                typeof(TravelQueryHandler<IPropertyContext, PagedAccommodationItemsByLanguageIdQuery,
                    IQueryable<Property.Accommodation>,
                    IResultWithTotalCount<AccommodationItem>>);

            //Act
            var handler = Handler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void Inherits_From_PropertyQueryHandler_Of_PagedAccommodationItemsByLanguageIdQuery_Comma_IQueryable_Of_Accommodation_Comma_IResultWithTotalCount_Of_AccommodationItem()
        {
            //Arrange
            var type =
                typeof(QueryHandler<PagedAccommodationItemsByLanguageIdQuery, IQueryable<Property.Accommodation>,
                    IResultWithTotalCount<AccommodationItem>>);

            //Act
            var handler = Handler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        private static PagedAccommodationItemsByLanguageIdQueryHandler Handler()
        {
            var contextMock = new Mock<IPropertyContext>();
            var projectorMock = new Mock<IProjection>();

            var handler = new PagedAccommodationItemsByLanguageIdQueryHandler(contextMock.Object, projectorMock.Object);
            return handler;
        }

        [Test]
        public void HandleAsync_Return_Task_Of_IResultWithTotalCount_Of_AccommodationItem()
        {
            //Arrange
            var type = typeof(Task<IResultWithTotalCount<AccommodationItem>>);
            var handler = Handler();
            var providerMock = new Mock<IProvider>();
            var query = new PagedAccommodationItemsByLanguageIdQuery(providerMock.Object);

            //Act
            var result = handler.HandleAsync(query);

            //Assert
            Assert.IsInstanceOf(type, result);
        }
    }
}