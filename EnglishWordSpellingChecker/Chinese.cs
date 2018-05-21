using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class Chinese
    {
        private Word _word;

        private const int QUESTION_QUANTITY = 1081;
        private const string SEPARATE_WORD = ">>>";

        public Chinese()
        {
            _word = new Word();
        }

        // Get question(Chinese) from file
        public List<string> GetChinese()
        {
            return _word.GetQuestion();
        }
    }
}
