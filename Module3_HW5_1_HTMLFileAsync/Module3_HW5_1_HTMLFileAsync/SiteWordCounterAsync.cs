using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW5_1_HTMLFileAsync
{
    public class SiteWordCounterAsync
    {
        public Dictionary<string, int> SiteWords { get; } = new Dictionary<string, int>();

        public async Task ProcessWithSiteAsync(string[] urls) 
        {
            SiteDownloader siteDownloader = new SiteDownloader();
            FileRead fileRead = new FileRead();
            WordCounter wordCounter = new WordCounter();
            WordSplitter wordSplitter = new WordSplitter();
            foreach (var url in urls) 
            {
                string normalizeUrl = siteDownloader.NormalizeUrl(url);
                string html = await siteDownloader.SiteDownload(url);
                if (!string.IsNullOrEmpty(html))
                {
                    var words = wordSplitter.WordSplit(html);
                    var uniqueWord = words.Distinct().ToList();
                    SiteWords[normalizeUrl] = uniqueWord.Count();

                    Console.WriteLine($"Amount of unique symbols {normalizeUrl} - {uniqueWord.Count}");

                    var wordCounts = wordCounter.countWord(words);
                    var sortedWords = uniqueWord.OrderByDescending(word => wordCounts[word]).ToList();
                    Console.WriteLine(string.Join("\n", sortedWords.Select(word => $"{word} - {wordCounts[word]}")));
                    Console.WriteLine();
                }
            }
        }
    }
}
