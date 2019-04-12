﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Mapping;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Unit.Tests.QueryHandlers
{
    public class QueryHandlerTest
    {
        [Test]
        public void Context()
        {
            //Arrange
            var contextMock = new Mock<TravelDbContext>();
            var projectorMock = new Mock<IProjection>();

            //Act
            var handler = new AwesomeQueryHandler(contextMock.Object, projectorMock.Object);

            //Assert
            Assert.AreSame(contextMock.Object, handler.TestContext);
        }
    }
}