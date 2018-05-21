using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class Word
    {
        private const int QUESTION_QUANTITY = 1081;
        private const string EMPTY_LINE = "";
        private const string SEPARATE_WORD = ">>>";

        List<string> _vocabulary;
        List<string> _dictionary;
        List<string> _question;

        public Word()
        {
            _vocabulary = new List<string>();
            StreamReader file = new StreamReader(@"../../../Source/Dictionary.txt", Encoding.Default);// Create a stream reader from the specific file
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();// Read a new line
                if (line.Equals(EMPTY_LINE))// Ignore the line, if it is empty
                    continue;
                _vocabulary.Add(line);
            }
            file.Close();

            _dictionary = new List<string>();
            _question = new List<string>();
            for (int i = 0; i < QUESTION_QUANTITY; i++)
            {
                string[] separateString = Regex.Split(_vocabulary[i], SEPARATE_WORD, RegexOptions.IgnoreCase);
                _dictionary.Add(separateString[0].Trim());
                _question.Add(separateString[1].Trim());
            }
        }

        // Get dictionary(English) from file
        public List<string> GetDictionary()
        {
            return _dictionary;
        }

        // Get question(Chinese) from file
        public List<string> GetQuestion()
        {
            return _question;
        }
    }
}
