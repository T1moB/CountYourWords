using System;
using System.Linq;

namespace CountYourWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITextReader reader = new TextFileReader();
            IWordProcessor processor = new WordProcessor();
            IWordCounter counter = new WordCounter();
            ISorter sorter = new SimpleSorter();

            string text = reader.ReadText();
            Console.WriteLine(text);
            var words = processor.Process(text);
            var wordCount = counter.CountWords(words);
            var sorted = sorter.Sort(wordCount);

            Console.WriteLine($"Number of words: {words.Count()}");
            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            //Run the test here
            //Tests.Test_TextFileReader();
            //Tests.Test_WordProcessor();
            //Tests.Test_WordCounter();
            //Tests.Test_SimpleSorter();
        }
    }
}
