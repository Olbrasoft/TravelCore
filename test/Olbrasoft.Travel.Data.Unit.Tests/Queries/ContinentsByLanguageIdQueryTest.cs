﻿using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Querying;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Data.Unit.Tests.Queries
{
    [TestFixture]
    internal class ContinentsByLanguageIdQueryTest
    {
        [Test]
        public void Instance_Is_ByLanguageIdQuery_Of_IEnumerable_Of_CountryItem()
        {
            //Arrange
            var type = typeof(ByLanguageIdQuery<IEnumerable<ContinentItem>>);
            var providerMock = new Mock<IQueryDispatcher>();

            //Act
            var query = new ContinentsByLanguageIdQuery(providerMock.Object);

            //Assert
            Assert.IsInstanceOf(type, query);

        }

    }
}