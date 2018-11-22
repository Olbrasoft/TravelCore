﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Query;

namespace Olbrasoft.Travel.Data.Unit.Tests.Query
{
    [TestFixture]
    internal class GetCountriesByLanguageIdTest
    {
        [Test]
        public void Instance_Is_QueryWithDependentProvider_Of_IEnumerable_Of_CountryItem()
        {
            //Arrange
            var type = typeof(QueryWithDependentProvider<IEnumerable<CountryItem>>);

            //Act
            var query = GetCountriesByLanguageId();

            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void Instance_Is_Implement_Interface_IQuery_Of_IEnumerable_Of_CountryItem()
        {
            //Arrange
            var type = typeof(IQuery<IEnumerable<CountryItem>>);

            //Act
            var query = GetCountriesByLanguageId();
            
            //Assert
            Assert.IsInstanceOf(type, query);
        }

        [Test]
        public void GetSetLanguageId()
        {
            //Arrange
            const int languageId = 1033;
            var query = GetCountriesByLanguageId();

            //Act 
            query.LanguageId = languageId;

            //Assert
            Assert.IsTrue(languageId == query.LanguageId);
        }

        private static GetCountriesByLanguageId GetCountriesByLanguageId()
        {
            var providerMock = new Mock<IProvider>();

            //Act
            var query = new GetCountriesByLanguageId(providerMock.Object);
            return query;
        }
    }
}