using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyCodeChallenges.DailyCodeFunctions;

namespace UnitTestsDailyCode
{
    [TestClass]
    public class UnitTest1
    {
        DailyCodeChallengeFunctions dccf = new DailyCodeChallengeFunctions();
        [TestMethod]
        public void StringPeeler_With_Valid_String()
        {
            // Set up
            string[] testStrings = { "My very first", "myNextWithCamelCasing"," and with leading space", "then trailing space? ", "12345"};
            string[] expected = { "y very firs", "yNextWithCamelCasin", "and with leading spac", "hen trailing space?", "234"};
            for(int i = 0; i < testStrings.Length; i++)
            {
                string actual = dccf.StringPeeler(testStrings[i]);
                //Assertion
                Assert.AreEqual(expected[i], actual, "String Peeler not working correctly");
            }
        }

        [TestMethod]
        public void StringPeeler_With_Null_Value()
        {
            Assert.ThrowsException<System.ArgumentException>(() => dccf.StringPeeler(null));
        }

        [TestMethod]
        public void StringPeeler_With_Invalid_Strings()
        {
            Assert.ThrowsException<System.ArgumentException>(() => dccf.StringPeeler("to"));
            Assert.ThrowsException<System.ArgumentException>(() => dccf.StringPeeler("s"));
        }
    }
}
