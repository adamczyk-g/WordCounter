using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Model
{
    public class WordFrequencyCounter
    {
        private List<string> words;
        private Dictionary<string, int> wordFrequency;

        public WordFrequencyCounter()
        {
            words = new List<string>();
            wordFrequency = new Dictionary<string, int>();
        }

        public Dictionary<string, int> CountFrequency(string text)
        {
            wordFrequency.Clear();

            words = SplitTextToWords(RemoveUnwantedCharacters(text));

            foreach (string word in words)
            {
                if (!wordFrequency.ContainsKey(word))
                    wordFrequency.Add(word, words.FindAll(x => word == x).Count);
            }

            return wordFrequency;
        }

        public int TotalWords { get { return words.Count; } }

        public int TotalUniqueWords { get { return wordFrequency.Count; } }

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
