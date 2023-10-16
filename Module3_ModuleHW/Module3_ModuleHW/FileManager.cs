using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ModuleHW
{
    public class FileManager
    {
        private static string _filePath = "contacts.json";
        private static bool _access = false;
        private static ContactBook _book = new ContactBook();
        public async Task StartWithFile(string command) 
        {
            Mutex mutex = new Mutex(false, "ContactsFileLock");

            try
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
                    _access = true;
                }
                else
                {
                    throw new FileLoadException("You can't write to this file");
                }
            }
            catch (AbandonedMutexException)
            {
                _access = true;
                mutex.ReleaseMutex();
            }
            FileOperations fileOperations = new FileOperations(_filePath, _access);
            mutex.ReleaseMutex();
            switch (command) 
            {
                case "a":
                    await AddContactToFile(fileOperations);
                    break;
                case "b":
                    await DisplayAllContactsAsync(fileOperations);
                    break;
            }
        }

        public async Task AddContactToFile(FileOperations fileOperations)
        {
            Contact contact = ConsoleManager.GetInformationAboutUser();
            _book.AddContact(contact);
            await fileOperations.WriteContactsToFileAsync(_book.GetAllContacts().ToList());
        }

        private async Task DisplayAllContactsAsync(FileOperations fileOperations)
        {
            ConsoleManager.DisplayMessageOnConsole("List of Contacts: ");
            List<Contact> savedContacts = await fileOperations.ReadContactsFromFileAsync();
            foreach (var contact in savedContacts)
            {
                ConsoleManager.DisplayMessageOnConsole($"Name: {contact.Name}, Surname: {contact.Surname}, Phone: {contact.PhoneNumber}");
            }
        }


    }
}