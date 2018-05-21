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
    public class PresentationModelTests
    {
        PresentationModel _presentationModel;
        Quiz _quiz;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _quiz = new Quiz();
            _presentationModel = new PresentationModel(_quiz);
        }

        // Test PresentationModel.IsStartBoxVisible()
        [TestMethod()]
        public void IsStartBoxVisibleTest()
        {
            Assert.IsTrue(_presentationModel.IsStartBoxVisible());
            _quiz.ClickStart(10, "Pick up questions randomly");
            Assert.IsFalse(_presentationModel.IsStartBoxVisible());
        }

        // Test PresentationModel.IsType1Visible()
        [TestMethod()]
        public void IsType1VisibleTest()
        {
            Assert.IsFalse(_presentationModel.IsType1Visible());
            _quiz.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 1);
            Assert.IsTrue(_presentationModel.IsType1Visible());
            _quiz.ClickNext();
            _quiz.SetRandomQuestionType(2, 2);
            Assert.IsFalse(_presentationModel.IsType1Visible());
            _quiz.ClickNext();
            _quiz.SetRandomQuestionType(3, 3);
            Assert.IsFalse(_presentationModel.IsType1Visible());
        }

        // Test PresentationModel.IsType2Visible()
        [TestMethod()]
        public void IsType2VisibleTest()
        {
            Assert.IsFalse(_presentationModel.IsType2Visible());
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 1);
            Assert.IsFalse(_presentationModel.IsType2Visible());
            _presentationModel.ClickNext();
            _quiz.SetRandomQuestionType(2, 2);
            Assert.IsTrue(_presentationModel.IsType2Visible());
            _presentationModel.ClickNext();
            _quiz.SetRandomQuestionType(3, 3);
            Assert.IsTrue(_presentationModel.IsType2Visible());
        }

        // Test PresentationModel.SetOptionNotChecked()
        [TestMethod()]
        public void IsOption1CheckedTest()
        {
            Assert.IsFalse(_presentationModel.IsOptionChecked());
        }

        // Test PresentationModel.GetQuestionTitle()
        [TestMethod()]
        public void GetQuestionTitleTest()
        {
            Initialize();
            _presentationModel.ClickStart(10, "All fill-in-blanks questions");
            Assert.AreEqual("Q1 : Fill in the Blanks", _presentationModel.GetQuestionTitle());
            Initialize();
            _presentationModel.ClickStart(10, "All multiple-choices questions");
            Assert.AreEqual("Q1 : Multiple Choice Question", _presentationModel.GetQuestionTitle());
        }

        // Test PresentationModel.GetQuestion()
        [TestMethod()]
        public void GetQuestionTest()
        {
            Initialize();
            _presentationModel.ClickStart(10, "All fill-in-blanks questions");
            _quiz.SetRandomQuestionNumber(1, 0);
            Assert.AreEqual("[冠]一個;一種 ___ (1)", _presentationModel.GetQuestion());
            Initialize();
            _presentationModel.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 2);
            _quiz.SetRandomQuestionNumber(1, 0);
            Assert.AreEqual("a", _presentationModel.GetQuestion());
            Initialize();
            _presentationModel.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 3);
            _quiz.SetRandomQuestionNumber(1, 0);
            Assert.AreEqual("[冠]一個;一種", _presentationModel.GetQuestion());
        }

        // Test PresentationModel.GetAnswer()
        [TestMethod()]
        public void GetAnswerTest()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual(null, _presentationModel.GetAnswer());
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            _presentationModel.GetAnswer2Check(true, false, false, false);
            _presentationModel.GetAnswer2("[冠]一個;一種", "", "", "");
            Assert.AreEqual("Correct!!", _presentationModel.GetAnswer());
            _quiz.SetRandomQuestionType(2, 2);
            _quiz.SetRandomQuestionNumber(2, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            _presentationModel.GetAnswer2Check(true, false, false, false);
            _presentationModel.GetAnswer2("[冠]一個;一種", "", "", "");
            Assert.AreEqual("Correct!!", _presentationModel.GetAnswer());
            _quiz.SetRandomQuestionType(3, 3);
            _quiz.SetRandomQuestionNumber(3, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            _presentationModel.GetAnswer2Check(false, false, false, true);
            _presentationModel.GetAnswer2("", "", "", "a");
            Assert.AreEqual("Correct!!", _presentationModel.GetAnswer());
        }

        // Test PresentationModel.GetAnswer1(string userAnswer)
        [TestMethod()]
        public void GetAnswer1Test()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("zoo");
            Assert.AreEqual("Correct!!", _presentationModel.GetAnswer());
        }

        // Test PresentationModel.GetAnswer2Check(bool option1, bool option2, bool option3, bool option4)
        [TestMethod()]
        public void GetAnswer2CheckTest()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 2);
            _quiz.SetRandomQuestionNumber(1, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, true, false, false);
            _presentationModel.GetAnswer2("", "[名]動物園", "", "");
            Assert.AreEqual("Correct!!", _presentationModel.GetAnswer());
            _quiz.SetRandomQuestionType(2, 3);
            _quiz.SetRandomQuestionNumber(2, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, false, true, false);
            _presentationModel.GetAnswer2("", "", "zoo", "");
            Assert.AreEqual("Correct!!", _presentationModel.GetAnswer());
            _quiz.SetRandomQuestionType(3, 3);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, false, false, false);
            _presentationModel.GetAnswer2("", "", "", "");
            Assert.AreEqual("It should be zoo!!", _presentationModel.GetAnswer());
        }

        // Test PresentationModel.GetAnswer2(string userAnswer1, string userAnswer2, string userAnswer3, string userAnswer4)
        [TestMethod()]
        public void GetAnswer2Test()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 3);
            _quiz.SetRandomQuestionNumber(1, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, false, false, false);
            _presentationModel.GetAnswer2("", "", "", "");
            Assert.AreEqual("It should be zoo!!", _presentationModel.GetAnswer());
        }

        // Test PresentationModel.GetOption(int optionNumber)
        [TestMethod()]
        public void GetOptionTest()
        {
            bool isCorrect;
            Initialize();
            isCorrect = false;
            _presentationModel.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 2);
            _quiz.SetRandomQuestionNumber(1, 0);
            _presentationModel.GetOptionArray();
            for (int i = 1; i <= 4; i++)
            {
                if (_presentationModel.GetOption(i) == "[冠]一個;一種")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);

            Initialize();
            isCorrect = false;
            _presentationModel.ClickStart(10, "All multiple-choices questions");
            _quiz.SetRandomQuestionType(1, 3);
            _quiz.SetRandomQuestionNumber(1, 1080);
            _presentationModel.GetOptionArray();
            for (int i = 1; i <= 4; i++)
            {
                if (_presentationModel.GetOption(i) == "zoo")
                    isCorrect = true;
            }
            Assert.IsTrue(isCorrect);
        }

        // Test PresentationModel.GetMyAnswer()
        [TestMethod()]
        public void GetMyAnswerTest()
        {
            Assert.AreEqual(null, _presentationModel.GetMyAnswer());
        }

        // Test PresentationModel.ClickStart(int questionAmount, string questionType)
        [TestMethod()]
        public void ClickStartTest()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            Assert.IsFalse(_presentationModel.IsStartEnabled());
            Assert.IsTrue(_presentationModel.IsNextEnabled());
            Assert.IsTrue(_presentationModel.IsMyAnswerEnabled());
        }

        // Test PresentationModel.GetFinished(DateTime time)
        [TestMethod()]
        public void GetFinishedTest()
        {
            DateTime time = new DateTime();
            _presentationModel.ClickStart(5, "Pick up questions randomly");
            _presentationModel.ClickNext();
            _presentationModel.ClickNext();
            _presentationModel.ClickNext();
            _presentationModel.ClickNext();
            _presentationModel.ClickNext();
            _presentationModel.GetFinished(time);
            Assert.IsTrue(_presentationModel.IsStartEnabled());
            Assert.IsFalse(_presentationModel.IsNextEnabled());
            Assert.IsFalse(_presentationModel.IsMyAnswerEnabled());
        }

        // Test PresentationModel.IsFinished()
        [TestMethod()]
        public void IsFinishedTest()
        {
            _presentationModel.ClickStart(5, "Pick up questions randomly");
            Assert.IsFalse(_presentationModel.IsFinished());
            _presentationModel.ClickNext();
            Assert.IsFalse(_presentationModel.IsFinished());
            _presentationModel.ClickNext();
            Assert.IsFalse(_presentationModel.IsFinished());
            _presentationModel.ClickNext();
            Assert.IsFalse(_presentationModel.IsFinished());
            _presentationModel.ClickNext();
            Assert.IsFalse(_presentationModel.IsFinished());
            _presentationModel.ClickNext();
            Assert.IsTrue(_presentationModel.IsFinished());
            _presentationModel.GetNewQuiz();
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            Assert.IsFalse(_presentationModel.IsFinished());
            _quiz.ClickNext();
            Assert.IsFalse(_presentationModel.IsFinished());
            _presentationModel.ClickStop();
            Assert.IsTrue(_presentationModel.IsFinished());
        }

        // Test PresentationModel.GetResult()
        [TestMethod()]
        public void GetResultTest()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual("You pass 0 of 0 questions!!", _presentationModel.GetResult());
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            Assert.AreEqual("You pass 1 of 1 questions!!", _presentationModel.GetResult());
            _quiz.SetRandomQuestionType(2, 3);
            _quiz.SetRandomQuestionNumber(2, 540);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(true, false, false, false);
            _presentationModel.GetAnswer2("", "", "", "");
            Assert.AreEqual("You pass 1 of 2 questions!!", _presentationModel.GetResult());
            _quiz.SetRandomQuestionType(3, 2);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, true, false, false);
            _presentationModel.GetAnswer2("", "[名]動物園", "", "");
            Assert.AreEqual("You pass 2 of 3 questions!!", _presentationModel.GetResult());
        }

        // Test PresentationModel.GetScore(int questionAmount)
        [TestMethod()]
        public void GetScoreTest()
        {
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            Assert.AreEqual("Score : 0", _presentationModel.GetScore(10));
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            Assert.AreEqual("Score : 10", _presentationModel.GetScore(10));
            _quiz.SetRandomQuestionType(2, 3);
            _quiz.SetRandomQuestionNumber(2, 540);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(true, false, false, false);
            _presentationModel.GetAnswer2("", "", "", "");
            Assert.AreEqual("Score : 10", _presentationModel.GetScore(10));
            _quiz.SetRandomQuestionType(3, 2);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, true, false, false);
            _presentationModel.GetAnswer2("", "[名]動物園", "", "");
            Assert.AreEqual("Score : 20", _presentationModel.GetScore(10));
            Initialize();
            _presentationModel.ClickStart(13, "Pick up questions randomly");
            for (int i = 1; i <= 13; i++)
            {
                _quiz.SetRandomQuestionType(i, 1);
                _quiz.SetRandomQuestionNumber(i, 0);
                _presentationModel.ClickNext();
                _presentationModel.GetAnswer1("a");
            }
            Assert.AreEqual("Score : 100", _presentationModel.GetScore(13));
        }

        // Test PresentationModel.GetProgressBarValue()
        [TestMethod()]
        public void GetProgressBarValueTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(i, _presentationModel.GetProgressBarValue());
                _presentationModel.AddProgressBarValue();
            }
            Assert.AreEqual(0, _presentationModel.GetProgressBarValue());
        }

        // Test PresentationModel.GetSolutionList()
        [TestMethod()]
        public void GetSolutionListTest()
        {
            List<string> solutionList = new List<string>();
            _presentationModel.ClickStart(10, "Pick up questions randomly");
            _quiz.SetRandomQuestionType(1, 1);
            _quiz.SetRandomQuestionNumber(1, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            _presentationModel.GetAnswer();
            _quiz.SetRandomQuestionType(2, 3);
            _quiz.SetRandomQuestionNumber(2, 0);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(true, false, false, false);
            _presentationModel.GetAnswer2("", "", "", "");
            _presentationModel.GetAnswer();
            _quiz.SetRandomQuestionType(3, 2);
            _quiz.SetRandomQuestionNumber(3, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer2Check(false, false, false, true);
            _presentationModel.GetAnswer2("", "", "", "[名]動物園");
            _quiz.SetRandomQuestionType(4, 1);
            _quiz.SetRandomQuestionNumber(4, 1080);
            _presentationModel.ClickNext();
            _presentationModel.GetAnswer1("a");
            _presentationModel.GetAnswer();
            solutionList = _presentationModel.GetSolutionList();
            Assert.AreEqual("2. [冠]一個;一種 :  -> a", solutionList[0]);
            Assert.AreEqual("4. [名]動物園 : a -> zoo", solutionList[1]);
        }
    }
}