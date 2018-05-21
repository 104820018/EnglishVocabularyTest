/////////////////////////////////////////////////////////////////////////////////////
// Note:
//     1. PresentationModel不含任何controls
//     2. PresentationModel儲存、管理、控制control的狀態
//     3. PresentationModel將事件委派(delegate)給Model負責
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EnglishWordSpellingChecker
{
    public class PresentationModel
    {
        Quiz _quiz;
        // Constants
        private const int OPTION1 = 0;
        private const int OPTION2 = 1;
        private const int OPTION3 = 2;
        private const int OPTION4 = 3;
        private const int OPTION_NUMBER = 4;
        private const int TOTAL_SCORE = 100;
        private const int DEADLINE = 10;
        private const string MY_ANSWER = null;
        private const string RESULT_1 = "You pass ";
        private const string RESULT_2 = " of ";
        private const string RESULT_3 = " questions";
        private const string EXCLAMATION_MARK = "!!";
        private const string SCORE_TITLE = "Score : ";
        // Others
        private bool _isStartEnabled = true;
        private bool _isNextEnabled = false;
        private bool _isMyAnswerEnabled = false;
        private bool _isOptionChecked = false;
        private bool[] _checkArray;
        private string _answer1;
        private string _answer2;
        private string[] _optionArray;
        private int _value = 0;
        private int _miss = 0;

        public PresentationModel(Quiz quiz)
        {
            this._quiz = quiz;
        }

        // Check if start box is visibled
        public bool IsStartBoxVisible()
        {
            return _quiz.IsStartBoxVisible();
        }

        // Check if type 1 quiz is visibled
        public bool IsType1Visible()
        {
            return _quiz.IsType1Visible();
        }

        // Check if type 2 quiz is visibled
        public bool IsType2Visible()
        {
            return _quiz.IsType2Visible();
        }

        // Check if Start button is enabled
        public bool IsStartEnabled()
        {
            return _isStartEnabled;
        }

        // Check if Next button is enabled
        public bool IsNextEnabled()
        {
            return _isNextEnabled;
        }

        // Check if _myAnswer textbox is enabled
        public bool IsMyAnswerEnabled()
        {
            return _isMyAnswerEnabled;
        }

        // Make option not been checked
        public bool IsOptionChecked()
        {
            return _isOptionChecked;
        }

        // Get question's title
        public string GetQuestionTitle()
        {
            return _quiz.GetQuestionTitle();
        }

        // Get question
        public string GetQuestion()
        {
            return _quiz.GetQuestion();
        }

        // Check answer and get real answer
        public string GetAnswer()
        {
            _quiz.AddSolutionList();
            if (_answer1 != null)
                return _answer1;
            else
                return _answer2;
        }

        // Check answer and get real answer in type 1 question
        public void GetAnswer1(string userAnswer)
        {
            _answer1 = _quiz.GetAnswer1(userAnswer);
        }

        // Check if type 2 question's options are checked 
        public void GetAnswer2Check(bool option1, bool option2, bool option3, bool option4)
        {
            _checkArray = new bool[OPTION_NUMBER];
            bool[] optionArray = { option1, option2, option3, option4 };
            for (int i = 0; i < OPTION_NUMBER; i++)
                _checkArray[i] = optionArray[i];
        }

        // Check answer and get real answer in type 2 question
        public void GetAnswer2(string userAnswer1, string userAnswer2, string userAnswer3, string userAnswer4)
        {
            string userAnswer = null;
            string[] userAnswerArray = { userAnswer1, userAnswer2, userAnswer3, userAnswer4 };
            for (int i = 0; i < OPTION_NUMBER; i++)
                if (_checkArray[i])
                    userAnswer = userAnswerArray[i];
            _answer2 = _quiz.GetAnswer2(userAnswer);
        }

        // Get type 2 question's option array
        public void GetOptionArray()
        {
            _optionArray = new string[OPTION_NUMBER];
            _optionArray = _quiz.GetRandomOption();
        }

        // Get type 2 question's option
        public string GetOption(int optionNumber)
        {
            return _optionArray[optionNumber - 1];
        }

        // Get blank _myAnswer textbox
        public string GetMyAnswer()
        {
            return MY_ANSWER;
        }

        // Click Start and check question type
        public void ClickStart(int questionAmount, string questionType)
        {
            _miss = 0;
            _isStartEnabled = false;
            _isNextEnabled = _isMyAnswerEnabled = true;
            _quiz.ClickStart(questionAmount, questionType);
        }

        // Click Next and count question number
        public void ClickNext()
        {
            _quiz.ClickNext();
            _value = 0;
        }

        // Click Stop and end the quiz
        public void ClickStop()
        {
            _quiz.ClickStop();
        }

        // Run finish program
        public void GetFinished(DateTime time)
        {
            if (IsFinished())
            {
                time = new DateTime();
                _value = 0;
                _isStartEnabled = true;
                _isNextEnabled = _isMyAnswerEnabled = false;
            }
        }

        // Check if the quiz is finished
        public bool IsFinished()
        {
            return _quiz.IsFinished();
        }

        // Get new Quiz()
        public void GetNewQuiz()
        {
            if (_quiz.IsFinished())
                _quiz = new Quiz();
        }

        // Get the quiz result
        public string GetResult()
        {
            return RESULT_1 + _quiz.GetCorrectNumber() + RESULT_2 + _quiz.GetAnsweredNumber() + RESULT_3 + EXCLAMATION_MARK;
        }

        // Get the quiz score
        public string GetScore(int questionAmount)
        {
            int score = TOTAL_SCORE * _quiz.GetCorrectNumber() / questionAmount - _miss;
            return SCORE_TITLE + score;
        }

        // Add progress bar value
        public void AddProgressBarValue()
        {
            _value++;
        }

        // Get progress bar value
        public int GetProgressBarValue()
        {
            if (_value == DEADLINE)
            {
                _value = 0;
                _miss++;
            }
            return _value;
        }

        // Get solution list
        public List<string> GetSolutionList()
        {
            return _quiz.GetSolutionList();
        }
    }
}
