using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class Quiz
    {
        private FillInTheBlanks _type1Question;
        private MultipleChoiceQuestion _type2Question;
        private RandomNumber _randomNumber;
        private List<int> _randomWord;
        private List<int> _randomQuestionType;
        private List<string> _solution;
        // Constants
        private const int QUESTION_QUANTITY = 1081;
        private const int QUESTION_TYPE1 = 1;
        private const int QUESTION_TYPE2 = 2;
        private const int QUESTION_TYPE3 = 3;
        private const int QUESTION_OPTION_NUMBER = 4;
        private const char CHARACTER_BLANK = ' ';
        private const string ALL_TYPE_1 = "All fill-in-blanks questions";
        private const string ALL_TYPE_2 = "All multiple-choices questions";
        private const string QUESTION_TITLE = "Q";
        private const string QUESTION_TYPE_1 = "Fill in the Blanks";
        private const string QUESTION_TYPE_2 = "Multiple Choice Question";
        private const string COLON = " : ";
        private const string BLANK = " ";
        private const string DOT = ". ";
        // Others
        private int _lastQuestionNumber = 0;
        private int _questionAmount = 0;
        private int _questionCounter = 0;
        private bool _isFinished;

        public Quiz()
        {
            _questionAmount = _questionCounter = 0;
            _type1Question = new FillInTheBlanks();
            _type2Question = new MultipleChoiceQuestion();
            _randomNumber = new RandomNumber();
        }

        // Print out question's title
        public string GetQuestionTitle()
        {
            if (_randomQuestionType[_questionCounter] == 1)
                return QUESTION_TITLE + _questionCounter + COLON + QUESTION_TYPE_1;
            else
                return QUESTION_TITLE + _questionCounter + COLON + QUESTION_TYPE_2;
        }

        // Print out question
        public string GetQuestion()
        {
            if (_randomQuestionType[_questionCounter] == 1)
                return _type1Question.GetQuestion(_randomWord[_questionCounter]);
            else if (_randomQuestionType[_questionCounter] == QUESTION_TYPE2)
                return _type2Question.GetEnglishQuestion(_randomWord[_questionCounter]);
            else
                return _type2Question.GetChineseQuestion(_randomWord[_questionCounter]);
        }

        // Get type 2 question's option randomly
        public string[] GetRandomOption()
        {
            if (_randomQuestionType[_questionCounter] == QUESTION_TYPE2)
                return _type2Question.GetRandomChineseOption(_randomWord[_questionCounter]);
            else
                return _type2Question.GetRandomEnglishOption(_randomWord[_questionCounter]);
        }

        // Check user's answer in type 1 question
        public string GetAnswer1(string userAnswer)
        {
            if (GetAnsweredNumber() <= 0 || _randomQuestionType[_lastQuestionNumber] != 1)
                return null;
            else
                return _type1Question.GetAnswer(_randomWord[_lastQuestionNumber], userAnswer);
        }

        // Check user's answer in type 1 question
        public string GetAnswer2(string userAnswer)
        {
            if (GetAnsweredNumber() <= 0 || _randomQuestionType[_lastQuestionNumber] == 1)
                return null;
            else if (_randomQuestionType[_lastQuestionNumber] == QUESTION_TYPE2)
                return _type2Question.GetChineseAnswer(_randomWord[_lastQuestionNumber], userAnswer);
            else
                return _type2Question.GetEnglishAnswer(_randomWord[_lastQuestionNumber], userAnswer);
        }

        // Get last question type
        public int GetLastQuestionType()
        {
            if (GetAnsweredNumber() <= 0)
                return 0;
            else
                return _randomQuestionType[_lastQuestionNumber];
        }

        // Get how many question number did user answered
        public int GetAnsweredNumber()
        {
            return _questionCounter - 1;
        }

        // Check if start box is visibled
        public bool IsStartBoxVisible()
        {
            if (_questionCounter == 0)
                return true;
            else
                return false;
        }

        // Check if type 1 quiz is visibled
        public bool IsType1Visible()
        {
            if (_questionCounter == 0 || _randomQuestionType[_questionCounter] != 1)
                return false;
            else
                return true;
        }

        // Check if type 2 quiz is visibled
        public bool IsType2Visible()
        {
            if (_questionCounter == 0 || _randomQuestionType[_questionCounter] == 1)
                return false;
            else
                return true;
        }

        // Check if the quiz is finished
        public bool IsFinished()
        {
            if (_questionCounter > _questionAmount || _isFinished)
                return true;
            else
                return false;
        }

        // Click Start and check question type
        public void ClickStart(int questionAmount, string questionType)
        {
            _questionAmount = questionAmount;
            _randomWord = new List<int>();
            _randomWord = _randomNumber.GetRandomList(_questionAmount + 1, QUESTION_QUANTITY);
            _randomQuestionType = new List<int>();
            _solution = new List<string>();
            if (questionType == ALL_TYPE_1)
                _randomQuestionType = _randomNumber.GetRandomList2(_questionAmount + 1, QUESTION_TYPE1, QUESTION_TYPE1);
            else if (questionType == ALL_TYPE_2)
                _randomQuestionType = _randomNumber.GetRandomList2(_questionAmount + 1, QUESTION_TYPE2, QUESTION_TYPE3);
            else
                _randomQuestionType = _randomNumber.GetRandomList2(_questionAmount + 1, QUESTION_TYPE1, QUESTION_TYPE3);
            _questionCounter++;
        }

        // Click Next and count question number
        public void ClickNext()
        {
            _questionCounter++;
            _lastQuestionNumber = _questionCounter - 1;
        }

        // Click Stop and end the quiz
        public void ClickStop()
        {
            _questionCounter++;
            _lastQuestionNumber = _questionCounter - 1;
            SetFinished(true);
        }

        // Set the quiz finished
        public void SetFinished(bool isFinished)
        {
            _isFinished = isFinished;
        }

        // Set question type
        public void SetRandomQuestionType(int questionCounter, int type)
        {
            _randomQuestionType[questionCounter] = type;
        }

        // Set question number
        public void SetRandomQuestionNumber(int questionCounter, int number)
        {
            _randomWord[questionCounter] = number;
        }

        // Get correct nuber of the quiz
        public int GetCorrectNumber()
        {
            return _type1Question.GetCorrectNumber() + _type2Question.GetCorrectNumber();
        }

        // Add solution to list
        public void AddSolutionList()
        {
            if (_randomQuestionType[_lastQuestionNumber] == 1)
            {
                if (_type1Question.GetSolution() != null)
                    _solution.Add(_lastQuestionNumber + DOT + _type1Question.GetSolution());
                _type1Question.SetSolution();
            }
            else
            {
                if (_type2Question.GetSolution() != null)
                    _solution.Add(_lastQuestionNumber + DOT + _type2Question.GetSolution());
                _type2Question.SetSolution();
            }
        }

        // Get solution list
        public List<string> GetSolutionList()
        {
            return _solution;
        }
    }
}
