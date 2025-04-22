using System;
using System.Collections.Generic;

namespace CountYourWords
{
    internal class SimpleSorter : ISorter
    {
        public List<KeyValuePair<string, int>> Sort(Dictionary<string, int> wordCounts)
        {
            var items = new List<KeyValuePair<string, int>>(wordCounts);

            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    if (string.Compare(items[j].Key, items[j + 1].Key) > 0)
                    {
                        var temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }

            return items;
        }
    }
}
