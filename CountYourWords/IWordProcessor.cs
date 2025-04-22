using System;
using System.Collections.Generic;

namespace CountYourWords
{
    internal interface IWordProcessor
    {
        IEnumerable<string> Process(string text);
    }
}
