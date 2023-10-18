using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module3_HW5_1_HTMLFileAsync
{
    public class WordSplitter
    {
        //split string to List<string>
        public List<string> WordSplit(string text)
        {
            return Regex.Matches(text, @"\b\w+\b")
                .Cast<Match>()
                .Select(match => match.Value)
                .Where(word => !string.IsNullOrEmpty(word) && !ContainsSymbols(word))
                .ToList();
        }

        private bool ContainsSymbols(string word) 
        {
            char[] symbols = new char[] {'<', '>', ':', ';', '{', '}',
                '[', ']', ',', '.', '?', '|', '\\', '/', '\'', '"', '_' };
            for (int i = 0; i < symbols.Length; i++)
            {
                if (word.Contains(symbols[i]))
                {
                    return true;
                }
                else if (word.Any(char.IsDigit))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
