using PersonAgeDeterminationProblem;
using static PersonAgeDeterminationProblem.AgeCategoryDetermination;

namespace AgeCategoryDetermination_MSTest_Exceptions
{
    [TestClass]
    public class AgeCategoryDeterminationTests
    {
        [TestMethod]
        public void TestDetermineAgeCategory_Children()
        {
            string category = AgeCategoryDetermination.DetermineAgeCategory(5);
            Assert.AreEqual("Children", category);
        }

        [TestMethod]
        public void TestDetermineAgeCategory_Youth()
        {
            string category = AgeCategoryDetermination.DetermineAgeCategory(20);
            Assert.AreEqual("Youth", category);
        }

        [TestMethod]
        public void TestDetermineAgeCategory_Adults()
        {
            string category = AgeCategoryDetermination.DetermineAgeCategory(40);
            Assert.AreEqual("Adults", category);
        }

        [TestMethod]
        public void TestDetermineAgeCategory_Seniors()
        {
            string category = AgeCategoryDetermination.DetermineAgeCategory(70);
            Assert.AreEqual("Seniors", category);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAgeException))]
        public void TestDetermineAgeCategory_InvalidAge()
        {
            AgeCategoryDetermination.DetermineAgeCategory(-5); // This should throw an InvalidAgeException.
        }
    }
}