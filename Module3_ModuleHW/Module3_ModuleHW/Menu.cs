using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ModuleHW
{
    public class Menu
    {
        ContactBook book = new ContactBook();
        public void ShowMenu() 
        {
            Console.WriteLine("a - Add contact");
            Console.WriteLine("b - Search contact by parametr");
            Console.WriteLine("c - Display all contacts");
            Console.WriteLine("d - remove contact");
            Console.WriteLine("e - exit");
        }

        public void Start() 
        {
            bool exit = false;
            while (!exit) 
            {
                ShowMenu();
                Console.WriteLine("Input your choice ");
                string userChoice = Console.ReadLine();
                switch(userChoice)
                {
                    case "a":
                        ConsoleManager.AddContact();
                        Wait();
                        break;
                    case "b":
                        SubMenu();
                        Console.WriteLine("Input your choice ");
                        string command = Console.ReadLine();
                        switch (command)
                        {
                            case "a":
                                ConsoleManager.SearchContactByName();
                                break;
                            case "b":
                                ConsoleManager.SearchContactBySurname();
                                break;
                            case "c":
                                ConsoleManager.SearchContactByPhone();
                                break;
                            default:
                                Console.WriteLine("Input only a, b, c, d ");
                                break;
                        }
                        Wait();
                        break;
                    case "c":
                        ConsoleManager.DisplayAllContacts();
                        Wait();
                        break;
                    case "d":
                        ConsoleManager.RemoveContact();
                        Wait();
                        break;
                    case "e":
                        Console.WriteLine("Exit");
                        exit = true;
                        Wait();
                        break; 
                    default:
                        Console.WriteLine("Input only a, b, c, d, e");
                        Wait();
                        break;
                }
                Console.Clear();
            }
        }
        private void SubMenu() 
        {
            Console.WriteLine("a - search by Name \n" +
            "b - search by Surname \n" +
            "c - search by Phone");
        }

        private void Wait()
        {
            Console.WriteLine("Press any button");
            Console.ReadKey();
        }
    }
}
