using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class MultipleChoiceQuestion
    {
        private Chinese _chinese;
        private English _english;
        private RandomNumber _randomNumber;

        private const int QUESTION_OPTION_NUMBER = 4;
        private const int QUESTION_QUANTITY = 1081;
        private const int WRONG_ANSWER1 = 1;
        private const int WRONG_ANSWER2 = 2;
        private const int WRONG_ANSWER3 = 3;
        private const char CHARACTER_COMMA = ',';
        private const string BLANK = " ";
        private const string EXCLAMATION_MARK = "!!";
        private const string CORRECT_MESSAGE = "Correct";
        private const string WRONG_MESSAGE = "It should be";
        private const string COMMA = ",";
        private const string COLON = " : ";
        private const string ARROW = " -> ";

        private int _correctNumber;
        private List<int> _randomWrongWord;
        private bool _isChineseOption;
        private string _solution = null;

        public MultipleChoiceQuestion()
        {
            _chinese = new Chinese();
            _english = new English();
            _randomNumber = new RandomNumber();
            _randomWrongWord = new List<int>();
        }

        // Get type 2 English question
        public string GetEnglishQuestion(int questionNumber)
        {
            return _english.GetEnglish()[questionNumber];
        }

        // Get type 2 Chinese question
        public string GetChineseQuestion(int questionNumber)
        {
            return _chinese.GetChinese()[questionNumber];
        }

        // Get type 2 question's wrong options randomly
        public List<int> GetRandomWordList(int questionNumber)
        {
            List<int> randomWord = new List<int>();
            randomWord = _randomNumber.GetRandomList3(QUESTION_OPTION_NUMBER, questionNumber, QUESTION_QUANTITY);
            return randomWord;
        }

        // Get type 2 question's options randomly
        public string[] GetRandomOption(int questionNumber)
        {
            string[] option = new string[QUESTION_OPTION_NUMBER];
            _randomWrongWord = GetRandomWordList(questionNumber);
            if (_isChineseOption)
            {
                option[0] = _chinese.GetChinese()[questionNumber] + COMMA;
                for (int i = 1; i < QUESTION_OPTION_NUMBER; i++)
                    option[i] = _chinese.GetChinese()[_randomWrongWord[i]] + COMMA;
            }
            else
            {
                option[0] = _english.GetEnglish()[questionNumber] + COMMA;
                for (int i = 1; i < QUESTION_OPTION_NUMBER; i++)
                    option[i] = _english.GetEnglish()[_randomWrongWord[i]] + COMMA;
            }
            Array.Sort(option);
            string[] randomOptionArray = string.Concat(option).Split(CHARACTER_COMMA);
            return randomOptionArray;
        }

        // Get type 2 English question's Chinese options randomly
        public string[] GetRandomChineseOption(int questionNumber)
        {
            SetChineseOption(true);
            return GetRandomOption(questionNumber);
        }

        // Get type 2 Chinese question's English options randomly
        public string[] GetRandomEnglishOption(int questionNumber)
        {
            SetChineseOption(false);
            return GetRandomOption(questionNumber);
        }

        // Check user's answer in type 2 English question
        public string GetChineseAnswer(int questionNumber, string userAnswer)
        {
            if (userAnswer == _chinese.GetChinese()[questionNumber].ToString())
            {
                _solution = null;
                _correctNumber++;
                return CORRECT_MESSAGE + EXCLAMATION_MARK;
            }
            else
            {
                _solution = _english.GetEnglish()[questionNumber] + COLON + userAnswer + ARROW + _chinese.GetChinese()[questionNumber];
                return WRONG_MESSAGE + BLANK + _chinese.GetChinese()[questionNumber] + EXCLAMATION_MARK;
            }
        }

        // Check user's answer in type 2 Chinese question
        public string GetEnglishAnswer(int questionNumber, string userAnswer)
        {
            if (userAnswer == _english.GetEnglish()[questionNumber].ToString())
            {
                _solution = null;
                _correctNumber++;
                return CORRECT_MESSAGE + EXCLAMATION_MARK;
            }
            else
            {
                _solution = _chinese.GetChinese()[questionNumber] + COLON + userAnswer + ARROW + _english.GetEnglish()[questionNumber];
                return WRONG_MESSAGE + BLANK + _english.GetEnglish()[questionNumber] + EXCLAMATION_MARK;
            }
        }

        // Get correct number in type 2 question
        public int GetCorrectNumber()
        {
            return _correctNumber;
        }

        // Set if it is chinese option
        public void SetChineseOption(bool isChineseOption)
        {
            _isChineseOption = isChineseOption;
        }

        // Get if it is chinese option
        public bool IsChineseOption()
        {
            return _isChineseOption;
        }

        // Set solution to null
        public void SetSolution()
        {
            _solution = null;
        }

        // Get solution
        public string GetSolution()
        {
            return _solution;
        }
    }
}
