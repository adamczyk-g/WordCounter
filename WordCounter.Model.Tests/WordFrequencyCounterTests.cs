using NUnit.Framework;
using System.Collections.Generic;
using WordCounter.Model;

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
        public void One_word_on_input_is_one_word_on_output()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int> { { "oneword", 1 } };
            string input = "oneword";

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Two_word_on_input_is_two_word_on_output()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int> { { "firstword", 1 }, { "secondword", 1 } };
            string input = "firstword secondword";

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Remove_unwanted_characters_from_input()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int> { { "oneword", 1 } };
            string input = "`1234567890 -=[]; '\\,./~!@#$%^&*()_+{}:\"||<>?OneWord";

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Word_repeats_()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            Dictionary<string, int> expected = new Dictionary<string, int> { { "firstword", 2 }, { "secondword", 1 } };
            string input = "firstword secondword firstword";

            Dictionary<string, int> output = wordCounter.CountFrequency(input);

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Total_words_count()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            int expected = 3;
            string input = "firstword secondword firstword";

            wordCounter.CountFrequency(input);
            int output = wordCounter.TotalWords;

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Total_unique_words_count()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            int expected = 3;
            string input = "firstword secondword firstword thirdword secondword";

            wordCounter.CountFrequency(input);
            int output = wordCounter.TotalUniqueWords;

            Assert.AreEqual(expected, output);
        }
    }    
}
