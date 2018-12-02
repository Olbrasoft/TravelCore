﻿using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Unit.Tests.Query
{
    [TestFixture]
    internal class ContinentsByLanguageIdQueryTest
    {
        [Test]
        public void Instance_Is_ByLanguageIdQuery_Of_IEnumerable_Of_CountryItem()
        {
            //Arrange
            var type = typeof(ByLanguageIdQuery<IEnumerable<ContinentItem>>);
            var providerMock = new Mock<IProvider>();

            //Act
            var query = new ContinentsByLanguageIdQuery(providerMock.Object);

            //Assert
            Assert.IsInstanceOf(type, query);

        }

    }
}