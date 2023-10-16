using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ModuleHW
{
    public class ConsoleManager
    {
        private static ContactBook book = new ContactBook();
        private static List<Contact> _book { get; set; }

        public static void DisplayAllContacts() 
        {
            _book = book.GetAllContacts();
            ShowOnConsole(_book);
        }

        public static void AddContact()
        {
            Contact contact = GetInformationAboutUser();
            book.AddContact(contact);
        }

        public static void RemoveContact()
        {
            Contact contact = GetInformationAboutUser();
            book.RemoveContact(contact);
        }

        public static void SearchContactByPhone()
        {
            DisplayMessageOnConsole("Input phone number ");
            string number = Console.ReadLine();
            _book=book.SearchContactByNumber(number);
            ShowOnConsole(_book);
        }

        public static void SearchContactByName()
        {
            DisplayMessageOnConsole("Input Name ");
            string name = Console.ReadLine();
            _book = book.SearchContactByName(name);
            ShowOnConsole(_book);
        }

        public static void SearchContactBySurname()
        {
            DisplayMessageOnConsole("Input Surname ");
            string surname = Console.ReadLine();
            _book = book.SearchContactBySurname(surname);
            ShowOnConsole(_book);
        }

        public static Contact GetInformationAboutUser() 
        {
            DisplayMessageOnConsole("Input Name ");
            string name = Console.ReadLine();
            DisplayMessageOnConsole("Input Surname ");
            string surname = Console.ReadLine();
            DisplayMessageOnConsole("Input PhoneNumber ");
            string phoneNumber = Console.ReadLine();
            return new Contact(name, surname, phoneNumber);
        }

        private static void ShowOnConsole(List<Contact> book) 
        {
            foreach (var person in book)
            {
                Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}, PhoneNumber: {person.PhoneNumber}");
            }
        }
        public static void DisplayMessageOnConsole(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
