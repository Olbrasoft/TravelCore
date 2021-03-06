﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Querying;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.QueryHandlers;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.QueryHandlers
{
    [TestFixture]
    internal class PhotosOfAccommodationsByAccommodationIdsQueryHandlerTest
    {
        [Test]
        public void Inherits_From_TravelQueryHandler_Of_IPropertyContext_Comma_PhotosOfAccommodationsByAccommodationIdsQuery_Comma_IQueryable_Of_PhotoOfAccommodation_Comma_IEnumerable_Of_AccommodationPhoto()
        {
            //Arrange
            var type = typeof(TravelQueryHandler<PhotosOfAccommodationsByAccommodationIdsQuery,Photo, IEnumerable<AccommodationPhoto>>);

            //Act
            var handler = Handler();

            //Assert
            Assert.IsInstanceOf(type,handler);
        }

        private static PhotosOfAccommodationsByAccommodationIdsQueryHandler Handler()
        {
            var contextMock = new Mock<TravelDbContext>();
            var projectorMock = new Mock<IProjection>();

            var handler = new PhotosOfAccommodationsByAccommodationIdsQueryHandler(contextMock.Object, projectorMock.Object);
            return handler;
        }

        [Test]
        public void HandleAsync_Return_Task_Of_IEnumerable_Of_AccommodationPhoto()
        {
            //Arrange
            var type = typeof(Task<IEnumerable<AccommodationPhoto>>);
            var handler = Handler();
            var providerMock = new Mock<IQueryDispatcher>();
            var query = new PhotosOfAccommodationsByAccommodationIdsQuery(providerMock.Object);

            //Act
            var result = handler.HandleAsync(query);

            //Assert
            Assert.IsInstanceOf(type,result);

        }

    }
}