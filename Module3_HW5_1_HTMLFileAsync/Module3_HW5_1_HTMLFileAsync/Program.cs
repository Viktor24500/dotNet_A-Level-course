namespace Module3_HW5_1_HTMLFileAsync
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Input your urls with space");
            string[] urls = Console.ReadLine().Split(' ');

            SiteWordCounterAsync siteWordCounterAsync = new SiteWordCounterAsync();
            await siteWordCounterAsync.ProcessWithSiteAsync(urls);

            Console.WriteLine("amount of words");
            foreach (var kvp in siteWordCounterAsync.SiteWords)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        
        }
    }
}