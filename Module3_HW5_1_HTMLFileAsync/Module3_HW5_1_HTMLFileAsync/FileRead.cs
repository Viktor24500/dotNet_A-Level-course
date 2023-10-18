using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module3_HW5_1_HTMLFileAsync
{
    public class FileRead
    {
        public async Task<string> FileReadAsync(string FileName) 
        {
            try
            {
                return await File.ReadAllTextAsync(FileName);
            }
            catch (Exception) 
            {
                Console.WriteLine("File not open");
                return String.Empty;
            }
        }
    }
}
