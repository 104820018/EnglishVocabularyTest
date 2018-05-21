using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class FillInTheBlanks
    {
        private Chinese _chinese;
        private English _english;

        private const int LEAST_LETTERS = 2;
        private const string BLANK = " ";
        private const string UNDERLINE = "___";
        private const string OPEN_PAREN = "(";
        private const string CLOSE_PAREN = ")";
        private const string EXCLAMATION_MARK = "!!";
        private const string CORRECT_MESSAGE = "Correct";
        private const string WRONG_MESSAGE = "It should be";
        private const string COLON = " : ";
        private const string ARROW = " -> ";

        private string _solution = null;

        private int _correctNumber;

        public FillInTheBlanks()
        {
            _chinese = new Chinese();
            _english = new English();
        }

        // Get type 1 Chinese question
        public string GetQuestion(int questionNumber)
        {
            int letter = _english.GetLetterNumber(questionNumber);
            string chinese = _chinese.GetChinese()[questionNumber];
            char firstLetter = _english.GetFirstLetter(questionNumber);
            char lastLetter = _english.GetLastLetter(questionNumber);
            switch (letter)
            {
                case 1:
                    return chinese + BLANK + UNDERLINE + BLANK + OPEN_PAREN + letter + CLOSE_PAREN;
                case LEAST_LETTERS:
                    return chinese + BLANK + firstLetter + UNDERLINE + BLANK + OPEN_PAREN + letter + CLOSE_PAREN;
                default:
                    return chinese + BLANK + firstLetter + UNDERLINE + lastLetter + BLANK + OPEN_PAREN + letter + CLOSE_PAREN;
            }
        }

        // Check user's answer in type 2 Chinese question
        public string GetAnswer(int questionNumber, string userAnswer)
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

        // Get correct number in type 1 question
        public int GetCorrectNumber()
        {
            return _correctNumber;
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
