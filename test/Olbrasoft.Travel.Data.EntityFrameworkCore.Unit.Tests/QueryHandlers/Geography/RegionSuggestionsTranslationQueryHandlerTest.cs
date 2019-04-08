﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Querying;
using Olbrasoft.Travel.Data.EntityFrameworkCore.QueryHandlers;
using Olbrasoft.Travel.Data.EntityFrameworkCore.QueryHandlers.Geography;
using Olbrasoft.Travel.Data.Geography;
using Olbrasoft.Travel.Data.Queries.Geography;
using Olbrasoft.Travel.Data.Transfer.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.QueryHandlers.Geography
{
    public class RegionSuggestionsTranslationQueryHandlerTest
    {
        [Test]
        public void Instance_Is_TravelQueryHandler()
        {
            //Arrange
            var type = typeof(QueryHandler<RegionSuggestionsTranslationQuery, Region, IEnumerable<SuggestionDto>>);

            //Act
            var handler = CreateHandler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        private static RegionSuggestionsTranslationQueryHandler CreateHandler()
        {
            var contextMock = new Mock<TravelDbContext>();
            var projectorMock = new Mock<IProjection>();

            var handler = new RegionSuggestionsTranslationQueryHandler(contextMock.Object, projectorMock.Object);
            return handler;
        }

        [Test]
        public void HandleAsync_Returns_Task_Of_IEnumerable_Of_SuggestionDto()
        {
            //Arrange
            var type = typeof(Task<IEnumerable<SuggestionDto>>);
            var handler = CreateHandler();

            var dispatcherMock = new Mock<IQueryDispatcher>();
            var query = new RegionSuggestionsTranslationQuery(dispatcherMock.Object);

            //Act
            var result = handler.HandleAsync(query);

            //Assert
            Assert.IsInstanceOf(type, result);
        }
    }
}