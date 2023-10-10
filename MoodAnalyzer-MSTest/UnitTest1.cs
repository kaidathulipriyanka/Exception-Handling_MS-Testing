using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyzer_MSTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        public void TestAnalyzeMood_SadMood_ReturnsSAD()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = new MoodAnalyzer.MoodAnalyzer("I am in Sad Mood");
            string mood = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("SAD", mood);
        }

        [TestMethod]
        public void TestAnalyzeMood_AnyMood_ReturnsHAPPY()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = new MoodAnalyzer.MoodAnalyzer();
            string mood = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]
        public void TestCreateMoodAnalyzerObject_WithClassNameAndConstructorParameter_ReturnsMoodAnalyzerObject()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzer.MoodAnalyzer", "I am in Happy Mood");
            string mood = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestCreateMoodAnalyzerObject_WithInvalidClassName_ThrowsException()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = MoodAnalyzerFactory.CreateMoodAnalyzerObject("InvalidClassName", "I am in Happy Mood");
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestCreateMoodAnalyzerObject_WithInvalidConstructor_ThrowsException()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzer.MoodAnalyzer", "I am in Happy Mood", "ExtraParameter");
        }

        [TestMethod]
        public void TestInvokeAnalyzeMood_UsingReflection_ReturnsHAPPY()
        {
            string mood = MoodAnalyzerReflector.InvokeAnalyzeMood("I am in Happy Mood");
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestInvokeAnalyzeMood_WithInvalidMethodName_ThrowsException()
        {
            string mood = MoodAnalyzerReflector.InvokeAnalyzeMood("I am in Happy Mood", "InvalidMethodName");
        }

        [TestMethod]
        public void TestChangeMoodDynamically_SetHappyMessage_ReturnsHAPPY()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = new MoodAnalyzer.MoodAnalyzer("I am in Sad Mood");
            MoodAnalyzerReflector.ChangeMoodDynamically(moodAnalyzer, "message", "I am in Happy Mood");
            string mood = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestChangeMoodDynamically_SetInvalidField_ThrowsException()
        {
            MoodAnalyzer.MoodAnalyzer moodAnalyzer = new MoodAnalyzer.MoodAnalyzer("I am in Sad Mood");
            MoodAnalyzerReflector.ChangeMoodDynamically(moodAnalyzer, "invalidField", "I am in Happy Mood");
        }
    }
}