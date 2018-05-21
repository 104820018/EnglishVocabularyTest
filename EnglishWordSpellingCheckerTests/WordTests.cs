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
    public class WordTests
    {
        Word _word;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _word = new Word();
        }

        // Test Word.GetDictionary()
        [TestMethod()]
        public void GetDictionaryTest()
        {
            Assert.AreEqual("a", _word.GetDictionary()[0]);
            Assert.AreEqual("zoo", _word.GetDictionary()[1080]);
        }

        // Test Word.GetQuestion()
        [TestMethod()]
        public void GetQuestionTest()
        {
            Assert.AreEqual("[冠]一個;一種", _word.GetQuestion()[0]);
            Assert.AreEqual("[名]動物園", _word.GetQuestion()[1080]);
        }
    }
}