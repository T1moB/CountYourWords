using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountYourWords
{
    internal static class Tests
    {
        public static void Test_TextFileReader()
        {
            var reader = new TextFileReader("test_input.txt");

            File.WriteAllText("test_input.txt", "Hello world!");
            var result = reader.ReadText();

            Console.WriteLine(result == "Hello world!"
                ? "PASS: TextFileReader"
                : "FAIL: TextFileReader");

            File.Delete("test_input.txt");
        }

        public static void Test_WordProcessor()
        {
            var processor = new WordProcessor();

            string input = "The big brown FOX 123 jumped! over the lazy dog. \nTHE @ BIG brown.";
            var words = processor.Process(input);

            var expected = new List<string> {
                "the", "big", "brown", "fox", "jumped", "over", "the", "lazy", "dog", "the", "big", "brown"
            };

            bool pass = words.SequenceEqual(expected);
            Console.WriteLine(pass ? "PASS: WordProcessor" : "FAIL: WordProcessor");
        }

        public static void Test_WordCounter()
        {
            var wordList = new List<string> {
                "fox", "dog", "fox", "fox", "dog", "cat"
            };

            var counter = new WordCounter();
            var result = counter.CountWords(wordList);

            bool pass = result.Count == 3
                && result["fox"] == 3
                && result["dog"] == 2
                && result["cat"] == 1;

            Console.WriteLine(pass ? "PASS: WordCounter" : "FAIL: WordCounter");
        }
        public static void Test_SimpleSorter()
        {
            var unsorted = new Dictionary<string, int>
            {
                { "zebra", 1 },
                { "apple", 3 },
                { "monkey", 2 }
            };

            var sorter = new SimpleSorter();
            var result = sorter.Sort(unsorted);

            bool pass = result[0].Key == "apple"
                     && result[1].Key == "monkey"
                     && result[2].Key == "zebra";

            Console.WriteLine(pass ? "PASS: SimpleSorter" : "FAIL: SimpleSorter");
        }
    }
}
