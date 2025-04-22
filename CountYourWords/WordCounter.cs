using System;
using System.Collections.Generic;

namespace CountYourWords
{
    internal class WordCounter : IWordCounter
    {
        public Dictionary<string, int> CountWords(IEnumerable<string> words)
        {
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (result.ContainsKey(word))
                    result[word]++;
                else
                    result[word] = 1;
            }

            return result;
        }
    }
}
