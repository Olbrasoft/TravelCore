﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Base.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.Unit.Tests.Base.Objects.Accommodation
{
    public class PhotoTest
    {
        [Test]
        public void PropertyId()
        {
            //Arrange
            const int estateId = 1976;

            //Act
            var photo = new Photo
            {
                PropertyId = estateId
            };

            //Assert
            Assert.AreEqual(estateId, photo.PropertyId);
        }

        [Test]
        public void FileName()
        {
            //Arrange
            const string name = "Some File Name";

            //Act
            var photo = new Photo
            {
                FileName = name
            };

            //Assert
            Assert.AreEqual(name, photo.FileName);
        }
    }
}