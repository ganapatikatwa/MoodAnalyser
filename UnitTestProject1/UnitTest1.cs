using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Method_Should_Return_User_Mood()
        {
            ///AAA
            //Arrange
            string msg = "I am in Sad Mood";
            string expected = "sad";
            MoodAnalyser1 moodAnalyser1 = new MoodAnalyser1(msg);
            //Act
            string actual = moodAnalyser1.Analyser();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
