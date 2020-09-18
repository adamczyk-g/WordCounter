using NUnit.Framework;
using System.Collections.Generic;

namespace WordCounter.Model.Tests
{
    [TestFixture]
    public class WordFrequencyCounterTests
    {
        [Test]
        public void Empty_input_string_return_an_empty_list()
        {
            WordFrequencyCounter wordCounter = new WordFrequencyCounter();
            IEnumerable<WordFrequency> expected = new List<WordFrequency>();
            string input = string.Empty;

            IEnumerable< WordFrequency> output = wordCounter.CountFrequency(input);            

            CollectionAssert.AreEqual(expected, output);
        }

        public class WordFrequency
        {
            public WordFrequency(string word, int count)
            {
                Word = word;
                Count = count;
            }

            public string Word { get; }

            public int Count { get; }

            public override string ToString()
            {
                return Word + ", " + Count;
            }
        }

        public class WordFrequencyCounter
        {
            public WordFrequencyCounter() { }

            public IEnumerable <WordFrequency> CountFrequency(string text)
            {
                return new List<WordFrequency>();
            }
        }
    }
}
