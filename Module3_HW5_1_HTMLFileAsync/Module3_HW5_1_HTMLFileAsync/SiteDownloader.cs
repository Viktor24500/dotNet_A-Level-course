using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW5_1_HTMLFileAsync
{
    public class SiteDownloader
    {
        public async Task<string> SiteDownload(string url) 
        {
            url = NormalizeUrl(url);
            using (var client = new HttpClient())
            {
                try
                {
                    return await client.GetStringAsync(url);
                }
                catch (Exception) 
                {
                    Console.WriteLine($"Error while loading site {url}");
                    return string.Empty;
                }
            }
        }

        public string NormalizeUrl(string path) 
        {
            if ((!path.StartsWith("http://")) && (!path.StartsWith("https://")))
            {
                return "http://" + path;
            }
            return path;
        }
    }
}
