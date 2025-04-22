using System;
using System.IO;

namespace CountYourWords
{
    internal class TextFileReader : ITextReader
    {
        private readonly string _filePath;

        public TextFileReader(string filePath = "input.txt")
        {
            _filePath = filePath;
        }

        public string ReadText()
        {
            return File.Exists(_filePath)
                ? File.ReadAllText(_filePath)
                : string.Empty;
        }
    }
}
