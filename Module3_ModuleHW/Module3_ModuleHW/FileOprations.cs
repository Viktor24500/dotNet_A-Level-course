using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ModuleHW
{
    public class FileOperations
    {
        private string _filePath;
        private bool _access;

        public FileOperations(string filePath, bool access)
        {
            _filePath = filePath;
            _access = access;
        }

        public async Task WriteContactsToFileAsync(List<Contact> contacts)
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("file don't exist");
            }
            if (!_access)
            {
                throw new FileLoadException("you haven't access to this file");
            }
            try
            {
                string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    await writer.WriteAsync(json);
                }
            }
            catch (Exception) 
            {
                throw new Exception("file don't exist");
            }
        }

        public async Task<List<Contact>> ReadContactsFromFileAsync()
        {
            List<Contact> contacts = new List<Contact>();
            if (!File.Exists(_filePath)) 
            {
                throw new FileNotFoundException("file don't exist");
            }
            if (!_access)
            {
                throw new FileLoadException("you haven't access to this file");
            }
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string json = await reader.ReadToEndAsync();
                contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
            }
            return contacts;
        }
    }
}
