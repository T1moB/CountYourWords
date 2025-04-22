using System;
using System.Collections.Generic;

namespace CountYourWords
{
    internal interface IWordCounter
    {
        Dictionary<string, int> CountWords(IEnumerable<string> words);
    }
}
