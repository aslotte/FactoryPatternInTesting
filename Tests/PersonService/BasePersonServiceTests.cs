using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework.Factories;

namespace Tests
{
    public class BasePersonServiceTests
    {
        protected PersonFactory personFactory;
        protected PersonService unitUnderTest;

        [TestInitialize]
        public void Setup()
        {
            personFactory = new PersonFactory().WithDefault();
            unitUnderTest = new PersonService();
        }
    }
}
