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
    public class MultipleChoiceQuestionTests
    {
        MultipleChoiceQuestion _multiple;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _multiple = new MultipleChoiceQuestion();
        }

        // Test MultipleChoiceQuestion.GetEnglishQuestion(int questionNumber)
        [TestMethod()]
        public void GetEnglishQuestionTest()
        {
            Assert.AreEqual("a", _multiple.GetEnglishQuestion(0));
            Assert.AreEqual("zoo", _multiple.GetEnglishQuestion(1080));
        }

        // Test MultipleChoiceQuestion.GetChineseQuestion(int questionNumber)
        [TestMethod()]
        public void GetChineseQuestionTest()
        {
            Assert.AreEqual("[冠]一個;一種", _multiple.GetChineseQuestion(0));
            Assert.AreEqual("[名]動物園", _multiple.GetChineseQuestion(1080));
        }

        // Test MultipleChoiceQuestion.GetRandomWordList(int questionNumber)
        [TestMethod()]
        public void GetRandomWordListTest()
        {
            List<int> randomWord = new List<int>();
            randomWord = _multiple.GetRandomWordList(0);
            Assert.AreNotEqual(0, randomWord[0]);
            Assert.AreNotEqual(0, randomWord[1]);
            Assert.AreNotEqual(0, randomWord[2]);
            Assert.AreNotEqual(0, randomWord[3]);
        }

        // Test MultipleChoiceQuestion.GetRandomOption(int questionNumber)
        [TestMethod()]
        public void GetRandomOptionTest()
        {
            bool isCorrect;
            isCorrect = false;
            _multiple.SetChineseOption(true);
            string[] randomChineseOption = _multiple.GetRandomOption(0);
            for (int i = 0; i < 4; i++)
            {
                if (randomChineseOption[i] == "[冠]一個;一種")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);

            isCorrect = false;
            _multiple.SetChineseOption(false);
            string[] randomEnglishOption = _multiple.GetRandomOption(0);
            for (int i = 0; i < 4; i++)
            {
                if (randomEnglishOption[i] == "a")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);
        }

        // Test MultipleChoiceQuestion.GetRandomChineseOption(int questionNumber)
        [TestMethod()]
        public void GetRandomChineseOptionTest()
        {
            bool isCorrect = false;
            string[] randomChineseOption = _multiple.GetRandomChineseOption(1080);
            for (int i = 0; i < 4; i++)
            {
                if (randomChineseOption[i] == "[名]動物園")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);
        }

        // Test MultipleChoiceQuestion.GetRandomEnglishOption(int questionNumber)
        [TestMethod()]
        public void GetRandomEnglishOptionTest()
        {
            bool isCorrect = false;
            string[] randomEnglishOption = _multiple.GetRandomEnglishOption(1080);
            for (int i = 0; i < 4; i++)
            {
                if (randomEnglishOption[i] == "zoo")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);
        }

        // Test MultipleChoiceQuestion.GetChineseAnswer(int questionNumber, string userAnswer)
        [TestMethod()]
        public void GetChineseAnswerTest()
        {
            Assert.AreEqual("Correct!!", _multiple.GetChineseAnswer(0, "[冠]一個;一種"));
            Assert.AreEqual("It should be [名]動物園!!", _multiple.GetChineseAnswer(1080, " "));
        }

        // Test MultipleChoiceQuestion.GetEnglishAnswer(int questionNumber, string userAnswer)
        [TestMethod()]
        public void GetEnglishAnswerTest()
        {
            Assert.AreEqual("It should be a!!", _multiple.GetEnglishAnswer(0, " "));
            Assert.AreEqual("Correct!!", _multiple.GetEnglishAnswer(1080, "zoo"));
        }

        // Test MultipleChoiceQuestion.GetCorrectNumber()
        [TestMethod()]
        public void GetCorrectNumberTest()
        {
            Assert.AreEqual(0, _multiple.GetCorrectNumber());
            _multiple.GetChineseAnswer(0, "[冠]一個;一種");
            Assert.AreEqual(1, _multiple.GetCorrectNumber());
            _multiple.GetEnglishAnswer(360, " ");
            Assert.AreEqual(1, _multiple.GetCorrectNumber());
            _multiple.GetChineseAnswer(720, " ");
            Assert.AreEqual(1, _multiple.GetCorrectNumber());
            _multiple.GetEnglishAnswer(1080, "zoo");
            Assert.AreEqual(2, _multiple.GetCorrectNumber());
        }

        // Test MultipleChoiceQuestion.SetChineseOption(bool isChineseOption)
        [TestMethod()]
        public void SetChineseOptionTest()
        {
            _multiple.SetChineseOption(true);
            Assert.IsTrue(_multiple.IsChineseOption());
            _multiple.SetChineseOption(false);
            Assert.IsFalse(_multiple.IsChineseOption());
        }

        // Test MultipleChoiceQuestion.GetSolution()
        [TestMethod()]
        public void GetSolutionTest()
        {
            _multiple.GetChineseAnswer(0, "[冠]一個;一種");
            Assert.IsNull(_multiple.GetSolution());
            _multiple.SetSolution();
            Assert.IsNull(_multiple.GetSolution());
            _multiple.GetChineseAnswer(1080, "");
            Assert.AreEqual("zoo :  -> [名]動物園", _multiple.GetSolution());
            _multiple.SetSolution();
            Assert.IsNull(_multiple.GetSolution());
            _multiple.GetEnglishAnswer(0, "zoo");
            Assert.AreEqual("[冠]一個;一種 : zoo -> a", _multiple.GetSolution());
            _multiple.SetSolution();
            Assert.IsNull(_multiple.GetSolution());
            _multiple.GetEnglishAnswer(1080, "zoo");
            Assert.IsNull(_multiple.GetSolution());
        }
    }
}