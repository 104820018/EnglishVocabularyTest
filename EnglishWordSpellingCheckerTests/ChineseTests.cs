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
    public class ChineseTests
    {
        Chinese _chinese;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _chinese = new Chinese();
        }

        // Test Chinese.GetChinese()
        [TestMethod()]
        public void GetChineseTest()
        {
            Assert.AreEqual("[冠]一個;一種", _chinese.GetChinese()[0]);
            Assert.AreEqual("[名]動物園", _chinese.GetChinese()[1080]);
        }
    }
}