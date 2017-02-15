using System.Collections.Generic;
using System;

namespace FindReplaceApp
{
    public class FindReplace
    {
        private string _sentence;
        private string _findWord;
        private string _replaceWord;

        public FindReplace(string sentence, string findWord, string replaceWord)
        {
            _sentence = sentence;
            _findWord = findWord;
            _replaceWord = replaceWord;
        }

        public string Getsentence()
        {
            return _sentence;
        }

        public string GetfindWord()
        {
            return _findWord;
        }

        public string GetreplaceWord()
        {
            return _replaceWord;
        }

        public string Replacein()
        {
            string sentence = Getsentence();
            string sentenceLower = Getsentence().ToLower();
            string findWord = GetfindWord().ToLower();
            string replaceWord = GetreplaceWord().ToLower();
            string result = "Error: word not found in sentence";

            if (sentence.Contains(findWord))
            {
                result = sentence.Replace(findWord, replaceWord);
            }

            return result;
        }
    }
}
