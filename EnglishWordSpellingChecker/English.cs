using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class English
    {
        private Word _word;

        private const int QUESTION_QUANTITY = 1081;
        private const string SEPARATE_WORD = ">>>";

        public English()
        {
            _word = new Word();
        }

        // Get dictionary(English) from file
        public List<string> GetEnglish()
        {
            return _word.GetDictionary();
        }

        // Get first letter in vocabulary
        public char GetFirstLetter(int questionNumber)
        {
            return GetEnglish()[questionNumber][0];
        }

        // Get last letter in vocabulary
        public char GetLastLetter(int questionNumber)
        {
            int letter = GetEnglish()[questionNumber].Length;
            return GetEnglish()[questionNumber][letter - 1];
        }

        // Get letter number in vocabulary
        public int GetLetterNumber(int questionNumber)
        {
            return GetEnglish()[questionNumber].Length;
        }
    }
}
