using System;
using Business;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework.Factories;

namespace Tests
{
    [TestClass]
    public class UpdatePersonTests
    {
        private PersonFactory personFactory;
        private PersonService unitUnderTest;

        [TestInitialize]
        public void Setup()
        {
            personFactory = new PersonFactory().WithDefault();
            unitUnderTest = new PersonService();
        }

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SavePerson_IdNotValid_ShouldThrowExpcetion()
        {
            //Arrange
            var person = personFactory.WithId(-1).Create();

            //Act and Assert
            unitUnderTest.SavePerson(person);
        }
    }
}
