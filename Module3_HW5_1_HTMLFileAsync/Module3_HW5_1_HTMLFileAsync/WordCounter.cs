using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW5_1_HTMLFileAsync
{
    public class WordCounter
    {
        public Dictionary<string, int> countWord(List<string> words) 
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            foreach (var item in words) 
            {
                if (countWords.ContainsKey(item))
                {
                    countWords[item] = countWords[item] + 1;
                }
                else 
                {
                    countWords[item] = 1;
                }
            }
            return countWords;
        }

    }
}
