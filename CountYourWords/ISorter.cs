using System;
using System.Collections.Generic;

namespace CountYourWords
{
    internal interface ISorter
    {
        List<KeyValuePair<string, int>> Sort(Dictionary<string, int> wordCounts);
    }
}
