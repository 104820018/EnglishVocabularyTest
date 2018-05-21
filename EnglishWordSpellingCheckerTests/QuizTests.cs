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
    public class QuizTests
    {
        Quiz _quiz;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _quiz = new Quiz();
        }

        // Test Quiz.GetQuestionTitle()
        [TestMethod()]
        public void GetQuestionTitleTest()
        {
            Initialize();
            _quiz.ClickStart(10, "All fill-in-blanks questions");
            Assert.AreEqual("Q1 : Fill in the Blanks", _quiz.GetQuestionTitle());
            Initialize();
            _quiz.ClickStart(10, "All multiple-choices questions");
            Assert.AreEqual("Q1 : Multiple Choice Question", _quiz.GetQuestionTitle());
        }

        // Test Quiz.GetQuestion()
        [TestMethod()]
        public void GetQuestionTest()
        {
            Initialize();
            _quiz.ClickStart(10, "All fill-in-blanks questions");
            _quiz.SetRandomQuestionNumber(1, 0);
            Assert.AreEqual("[冠]一個;一種 ___ (1)", _quiz.GetQuestion());
            Initialize();
            _quiz.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 2);
            _quiz.SetRandomQuestionNumber(1, 0);
            Assert.AreEqual("a", _quiz.GetQuestion());
            Initialize();
            _quiz.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 3);
            _quiz.SetRandomQuestionNumber(1, 0);
            Assert.AreEqual("[冠]一個;一種", _quiz.GetQuestion());
        }

        // Test Quiz.GetRandomOption()
        [TestMethod()]
        public void GetRandomOptionTest()
        {
            string[] optionArray;
            bool isCorrect;
            Initialize();
            isCorrect = false;
            _quiz.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 2);
            _quiz.SetRandomQuestionNumber(1, 0);
            optionArray = _quiz.GetRandomOption();
            for (int i = 0; i < 4; i++)
            {
                if (optionArray[i] == "[冠]一個;一種")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);

            Initialize();
            isCorrect = false;
            _quiz.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 3);
            _quiz.SetRandomQuestionNumber(1, 1080);
            optionArray = _quiz.GetRandomOption();
            for (int i = 0; i < 4; i++)
            {
                if (optionArray[i] == "zoo")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);
        }

        // Test Quiz.GetAnswer(string userAnswer)
        [TestMethod()]
        public void GetAnswerTest()
        {
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.IsNull(_quiz.GetAnswer1(""));
            Assert.IsNull(_quiz.GetAnswer2(""));
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _quiz.ClickNext();
            Assert.AreEqual("Correct!!", _quiz.GetAnswer1("a"));
            _quiz.SetRandomQuestionType(2, 2);
            _quiz.SetRandomQuestionNumber(2, 0);
            _quiz.ClickNext();
            Assert.AreEqual("Correct!!", _quiz.GetAnswer2("[冠]一個;一種"));
            _quiz.SetRandomQuestionType(3, 3);
            _quiz.SetRandomQuestionNumber(3, 0);
            _quiz.ClickNext();
            Assert.AreEqual("Correct!!", _quiz.GetAnswer2("a"));
        }

        // Test Quiz.GetLastQuestionType()
        [TestMethod()]
        public void GetLastQuestionTypeTest()
        {
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual(0, _quiz.GetLastQuestionType());
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _quiz.ClickNext();
            Assert.AreEqual(1, _quiz.GetLastQuestionType());
            _quiz.SetRandomQuestionType(2, 2);
            _quiz.SetRandomQuestionNumber(2, 540);
            _quiz.ClickNext();
            Assert.AreEqual(2, _quiz.GetLastQuestionType());
            _quiz.SetRandomQuestionType(3, 3);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _quiz.ClickNext();
            Assert.AreEqual(3, _quiz.GetLastQuestionType());
        }

        // Test Quiz.GetAnsweredNumber()
        [TestMethod()]
        public void GetAnsweredNumberTest()
        {
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual(0, _quiz.GetAnsweredNumber());
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _quiz.ClickNext();
            Assert.AreEqual(1, _quiz.GetAnsweredNumber());
            _quiz.SetRandomQuestionType(2, 2);
            _quiz.SetRandomQuestionNumber(2, 540);
            _quiz.ClickNext();
            Assert.AreEqual(2, _quiz.GetAnsweredNumber());
            _quiz.SetRandomQuestionType(3, 3);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _quiz.ClickNext();
            Assert.AreEqual(3, _quiz.GetAnsweredNumber());
        }

        // Test Quiz.IsStartBoxVisible()
        [TestMethod()]
        public void IsStartBoxVisibleTest()
        {
            Assert.IsTrue(_quiz.IsStartBoxVisible());
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.IsFalse(_quiz.IsStartBoxVisible());
        }

        // Test Quiz.IsType1Visible()
        [TestMethod()]
        public void IsType1VisibleTest()
        {
            Assert.IsFalse(_quiz.IsType1Visible());
            _quiz.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 1);
            Assert.IsTrue(_quiz.IsType1Visible());
            _quiz.ClickNext();
            _quiz.SetRandomQuestionType(2, 2);
            Assert.IsFalse(_quiz.IsType1Visible());
            _quiz.ClickNext();
            _quiz.SetRandomQuestionType(3, 3);
            Assert.IsFalse(_quiz.IsType1Visible());

        }

        // Test Quiz.IsType2Visible()
        [TestMethod()]
        public void IsType2VisibleTest()
        {
            Assert.IsFalse(_quiz.IsType2Visible());
            _quiz.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 1);
            Assert.IsFalse(_quiz.IsType2Visible());
            _quiz.ClickNext();
            _quiz.SetRandomQuestionType(2, 2);
            Assert.IsTrue(_quiz.IsType2Visible());
            _quiz.ClickNext();
            _quiz.SetRandomQuestionType(3, 3);
            Assert.IsTrue(_quiz.IsType2Visible());
        }

        // Test Quiz.IsFinished()
        [TestMethod()]
        public void IsFinishedTest()
        {
            _quiz.ClickStart(5, "Pick up questions randomly");
            for (int i = 0; i < 5; i++)
            {
                Assert.IsFalse(_quiz.IsFinished());
                _quiz.ClickNext();
            }
            Assert.IsTrue(_quiz.IsFinished());

            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.IsFalse(_quiz.IsFinished());
            _quiz.ClickNext();
            Assert.IsFalse(_quiz.IsFinished());
            _quiz.ClickStop();
            Assert.IsTrue(_quiz.IsFinished());
        }

        // Test Quiz.SetFinished(bool isFinished)
        [TestMethod()]
        public void SetFinishedTest()
        {
            _quiz.SetFinished(true);
            Assert.IsTrue(_quiz.IsFinished());
            _quiz.SetFinished(false);
            Assert.IsFalse(_quiz.IsFinished());
        }

        // Test Quiz.GetCorrectNumber()
        [TestMethod()]
        public void GetCorrectNumberTest()
        {
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual(0, _quiz.GetCorrectNumber());
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _quiz.ClickNext();
            _quiz.GetAnswer1("a");
            Assert.AreEqual(1, _quiz.GetCorrectNumber());
            _quiz.SetRandomQuestionType(2, 3);
            _quiz.SetRandomQuestionNumber(2, 540);
            _quiz.ClickNext();
            _quiz.GetAnswer2("");
            Assert.AreEqual(1, _quiz.GetCorrectNumber());
            _quiz.SetRandomQuestionType(3, 2);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _quiz.ClickNext();
            _quiz.GetAnswer2("[名]動物園");
            Assert.AreEqual(2, _quiz.GetCorrectNumber());
        }

        // Test Quiz.GetSolutionQuiz()
        [TestMethod()]
        public void GetSolutionListTest()
        {
            List<string> solutionList = new List<string>();
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual(0, _quiz.GetCorrectNumber());
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _quiz.ClickNext();
            _quiz.GetAnswer1("a");
            _quiz.AddSolutionList();
            _quiz.SetRandomQuestionType(2, 3);
            _quiz.SetRandomQuestionNumber(2, 0);
            _quiz.ClickNext();
            _quiz.GetAnswer2("");
            _quiz.AddSolutionList();
            _quiz.SetRandomQuestionType(3, 2);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _quiz.ClickNext();
            _quiz.GetAnswer2("[名]動物園");
            _quiz.AddSolutionList();
            _quiz.SetRandomQuestionType(4, 1);
            _quiz.SetRandomQuestionNumber(4, 1080);
            _quiz.ClickNext();
            _quiz.GetAnswer1("a");
            _quiz.AddSolutionList();
            solutionList = _quiz.GetSolutionList();
            Assert.AreEqual("2. [冠]一個;一種 :  -> a", solutionList[0]);
            Assert.AreEqual("4. [名]動物園 : a -> zoo", solutionList[1]);
        }
    }
}