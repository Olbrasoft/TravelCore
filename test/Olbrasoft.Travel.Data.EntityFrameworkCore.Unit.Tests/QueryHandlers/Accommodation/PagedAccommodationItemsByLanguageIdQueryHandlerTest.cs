﻿using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Querying;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.QueryHandlers;
using Olbrasoft.Travel.Data.EntityFrameworkCore.QueryHandlers.Accommodation;
using Olbrasoft.Travel.Data.Queries.Accommodation;
using Olbrasoft.Travel.Data.Transfer.Objects;
using Olbrasoft.Travel.Data.Transfer.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.QueryHandlers.Accommodation
{
    [TestFixture]
    internal class PagedAccommodationItemsByLanguageIdQueryHandlerTest
    {
        [Test]
        public void Inherits_From_TravelQueryHandler_Of_IPropertyContext_Comma_PagedAccommodationItemsByLanguageIdQuery_Comma_IQueryable_Of_Accommodation_Comma_IResultWithTotalCount_Of_AccommodationItem()
        {
            //Arrange
            var type =
                typeof(QueryHandler<PagedPropertyItemsTranslationQuery, Property,
                    IResultWithTotalCount<PropertyItem>>);

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
                typeof(Handler<PagedPropertyItemsTranslationQuery, IQueryable<Property>,
                    IResultWithTotalCount<PropertyItem>>);

            //Act
            var handler = Handler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        private static PagedPropertyItemsByLanguageIdQueryHandler Handler()
        {
            var contextMock = new Mock<TravelDbContext>();
            var projectorMock = new Mock<IProjection>();

            var handler = new PagedPropertyItemsByLanguageIdQueryHandler(contextMock.Object, projectorMock.Object);
            return handler;
        }

        [Test]
        public void HandleAsync_Return_Task_Of_IResultWithTotalCount_Of_AccommodationItem()
        {
            //Arrange
            var type = typeof(Task<IResultWithTotalCount<PropertyItem>>);
            var handler = Handler();
            var providerMock = new Mock<IQueryDispatcher>();
            var query = new PagedPropertyItemsTranslationQuery(providerMock.Object);

            //Act
            var result = handler.HandleAsync(query);

            //Assert
            Assert.IsInstanceOf(type, result);
        }
    }
}