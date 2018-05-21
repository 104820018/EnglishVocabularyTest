using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishWordSpellingChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker.Tests
{
    [TestClass()]
    public class EnglishTests
    {
        English _english;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _english = new English();
        }

        // Test English.GetEnglish()
        [TestMethod()]
        public void GetEnglishTest()
        {
            Assert.AreEqual("a", _english.GetEnglish()[0]);
            Assert.AreEqual("zoo", _english.GetEnglish()[1080]);
        }

        // Test English.GetFirstLetter(int questionNumber)
        [TestMethod()]
        public void GetFirstLetterTest()
        {
            Assert.AreEqual('a', _english.GetFirstLetter(0));
            Assert.AreEqual('z', _english.GetFirstLetter(1080));
        }

        // Test English.GetLastLetter(int questionNumber)
        [TestMethod()]
        public void GetLastLetterTest()
        {
            Assert.AreEqual('a', _english.GetLastLetter(0));
            Assert.AreEqual('o', _english.GetLastLetter(1080));
        }

        // Test English.GetLetterNumber(int questionNumber)
        [TestMethod()]
        public void GetLetterNumberTest()
        {
            Assert.AreEqual(1, _english.GetLetterNumber(0));
            Assert.AreEqual(3, _english.GetLetterNumber(1080));
        }
    }
}