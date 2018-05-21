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
    public class FillInTheBlanksTests
    {
        FillInTheBlanks _fill;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _fill = new FillInTheBlanks();
        }

        // Test FillInTheBlanks.GetQuestion(int questionNumber)
        [TestMethod()]
        public void GetQuestionTest()
        {
            Assert.AreEqual("[冠]一個;一種 ___ (1)", _fill.GetQuestion(0));
            Assert.AreEqual("[動]是,在;be動詞第一人稱,單數,現在式 a___ (2)", _fill.GetQuestion(25));
            Assert.AreEqual("[名]動物園 z___o (3)", _fill.GetQuestion(1080));
        }

        // Test FillInTheBlanks.GetAnswer(int questionNumber, string userAnswer)
        [TestMethod()]
        public void GetAnswerTest()
        {
            Assert.AreEqual("Correct!!", _fill.GetAnswer(0, "a"));
            Assert.AreEqual("It should be a!!", _fill.GetAnswer(0, ""));
            Assert.AreEqual("It should be a!!", _fill.GetAnswer(0, "A"));
            Assert.AreEqual("Correct!!", _fill.GetAnswer(1080, "zoo"));
            Assert.AreEqual("It should be zoo!!", _fill.GetAnswer(1080, " "));
            Assert.AreEqual("It should be zoo!!", _fill.GetAnswer(1080, "zao"));
        }

        // Test FillInTheBlanks.GetCorrectNumber()
        [TestMethod()]
        public void GetCorrectNumberTest()
        {
            Assert.AreEqual(0, _fill.GetCorrectNumber());
            _fill.GetAnswer(0, "a");
            Assert.AreEqual(1, _fill.GetCorrectNumber());
            _fill.GetAnswer(540, " ");
            Assert.AreEqual(1, _fill.GetCorrectNumber());
            _fill.GetAnswer(1080, "zoo");
            Assert.AreEqual(2, _fill.GetCorrectNumber());
        }

        // Test FillInTheBlanks.GetSolution()
        [TestMethod()]
        public void GetSolutionTest()
        {
            _fill.GetAnswer(0, "a");
            Assert.IsNull(_fill.GetSolution());
            _fill.SetSolution();
            Assert.IsNull(_fill.GetSolution());
            _fill.GetAnswer(1080, "");
            Assert.AreEqual("[名]動物園 :  -> zoo", _fill.GetSolution());
            _fill.SetSolution();
            Assert.IsNull(_fill.GetSolution());
        }
    }
}