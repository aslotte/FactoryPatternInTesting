using System;
using Business;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework.Factories;

namespace Tests
{
    [TestClass]
    public class UpdatePersonTests : BasePersonServiceTests
    {
        [TestMethod]
        public void UpdateId_ShouldUpdateId()
        {
            //Arrange
            var expectedId = 3;
            var person = personFactory.Create();

            //Act
            unitUnderTest.UpdateId(person, expectedId);

            //Assert
            Assert.AreEqual(expectedId, person.Id);
        }

        [TestMethod]
        public void UpdateFirstName_ShouldSetFirstName()
        {
            //Arrange
            var expectedName = "Alexander";
            var person = personFactory.Create();

            //Act
            unitUnderTest.UpdateFirstName(person, expectedName);

            //Assert
            Assert.AreEqual(expectedName, person.FirstName);
        }
    }
}
