using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Model.Tests
{
    public class WordFrequencyCounter
    {
        private int totalWords;

        public WordFrequencyCounter() { }

        public Dictionary<string, int> CountFrequency(string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            List<string> words = SplitTextToWords(RemoveUnwantedCharacters(text));

            totalWords = words.Count;

            foreach (string word in words)
            {
                if (!wordFrequency.ContainsKey(word))
                    wordFrequency.Add(word, words.FindAll(x => word == x).Count);
            }

            return wordFrequency;
        }

        public int TotalWords => totalWords;

        private List<string> SplitTextToWords(string text)
        {
            return new List<string>(text.Split(new string[] { " ", "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries));
        }

        private string RemoveUnwantedCharacters(string text)
        {
            return Regex.Replace(text, "[^A-Za-z\r\n ]", "").ToLower();
        }
    }
}
