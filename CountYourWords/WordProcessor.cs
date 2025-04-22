using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountYourWords
{
    internal class WordProcessor : IWordProcessor
    {
        public IEnumerable<string> Process(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return new List<string>();

            // Remove everything that's not a letter or whitespace
            var cleaned = Regex.Replace(text, @"[^a-zA-Z\s]", " ");

            // Split on any whitespace (space, newline, tab, etc.)
            var words = Regex.Split(cleaned, @"\s+");

            var result = new List<string>();
            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    result.Add(word.ToLower());
            }
            return result;
        }
    }
}
