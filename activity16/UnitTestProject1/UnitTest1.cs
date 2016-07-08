// Manan Patel
// CMPSC 302
// Activity 16
// 3/22/2016

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using activity16;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an object
            Gradebook gb = new Gradebook();
            //check to see if the test fails or passes based on the comparision
            Assert.AreEqual("B+", gb.LetterGrade(88));
        }
    }
}
