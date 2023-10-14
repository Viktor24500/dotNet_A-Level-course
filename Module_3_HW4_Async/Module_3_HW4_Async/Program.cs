using System.IO;

namespace Module_3_HW4_Async
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string result = await TextAsync();
            Console.WriteLine(result);
        }

        public static async Task<string> HelloAsync() 
        {
            string path = "";
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    await writer.WriteLineAsync("Hello");
                }
            }
            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public static async Task<string> WorldAsync()
        {
            string path = "";
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    await writer.WriteLineAsync("World");
                }
            }
            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public static async Task<string> TextAsync() 
        {
            Task<string> hello = HelloAsync();
            Task<string> world = WorldAsync();

            await Task.WhenAll(hello, world);
            string helloStr = await hello;
            string worldStr = await world;
            return helloStr + worldStr;

        }
    }
}