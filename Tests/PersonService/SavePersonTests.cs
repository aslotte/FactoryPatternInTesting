using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class SavePersonTests : BasePersonServiceTests
    {
        [TestMethod]
        public void SavePerson_ShouldSaveAllInfo()
        {
            //Arrange
            var newPerson = personFactory
                .WithId(123)
                .WithFirstName("Alexander")
                .WithLastName("Smith")
                .WithPhoneNumber(2021234411)
                .Create();

            //Act
            unitUnderTest.SavePerson(newPerson);

            //Assert
            var savedPerson = unitUnderTest.GetPerson(newPerson.Id);

            Assert.IsTrue(newPerson.Equals(savedPerson));
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
