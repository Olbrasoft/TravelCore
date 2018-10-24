﻿using Microsoft.AspNetCore.Identity;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Identity;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Identity
{
    [TestFixture]
    internal class RoleClaimTest
    {
        [Test]
        public void Instance_Is_IdentityRoleClaim_Of_Integer()
        {
            //Arrange
            var type = typeof(IdentityRoleClaim<int>);

            //Act
            var roleClaim = new RoleClaim();

            //Assert
            Assert.IsInstanceOf(type,roleClaim);
        }


        [Test]
        public void Instance_Implement_Interface_IHaveDateAndTimeOfCreation()
        {
            //Arrange
            var type = typeof(IHaveDateTimeOfCreation);

            //Act
            var roleClaim = new RoleClaim();

            //Assert
            Assert.IsInstanceOf(type, roleClaim);
        }

    }
}