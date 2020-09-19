using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace WordCounter.Model.Tests
{
    [TestFixture]
    public class WordFrequencyCounterTests
    {
        [Test]
        public void Empty_input_string_return_an_empty_list()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int>();
            string input = string.Empty;

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void One_word_on_input_is_one_word_in_output()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int> { { "oneword", 1 } };
            string input = "oneword";

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Two_word_on_input_is_two_word_in_output()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int> { { "firstword", 1 }, { "secondword", 1 } };
            string input = "firstword secondword";

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }
    }

    public class WordFrequencyCounter
    {
        public WordFrequencyCounter() { }

        public Dictionary<string, int> CountFrequency(string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            List<string> words = SplitTextToWords(text);

            foreach (string word in words)
            {
                if (!wordFrequency.ContainsKey(word))
                    wordFrequency.Add(word, words.FindAll(x => word == x).Count);
            }

            return wordFrequency;
        }

        private List<string> SplitTextToWords(string text)
        {
            return new List<string>(text.Split(new string[] { " ", "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
