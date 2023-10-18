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
        public async Task Start() 
        {
            bool exit = false;
            while (!exit) 
            {
                ShowMenu();
                ConsoleManager.DisplayMessageOnConsole("Input your choice ");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "a":
                        ShowConsoleMenu();
                        ConsoleManager.DisplayMessageOnConsole("Input your choice ");
                        userChoice = Console.ReadLine();
                        switch (userChoice)
                        {
                            case "a":
                                ConsoleManager.AddContact();
                                Wait();
                                break;
                            case "b":
                                SubMenu();
                                ConsoleManager.DisplayMessageOnConsole("Input your choice ");
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
                                        ConsoleManager.DisplayMessageOnConsole("Input only a, b, c ");
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
                            default:
                                ConsoleManager.DisplayMessageOnConsole("Input only a, b, c, d");
                                Wait();
                                break;
                        }
                        break;
                    case "b":
                        FileManager fileManager = new FileManager();
                        FileMenu();
                        ConsoleManager.DisplayMessageOnConsole("Input your choice ");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "a":
                                await fileManager.StartWithFile("a");
                                break;
                            case "b":
                                await fileManager.StartWithFile("b");
                                break;
                            default:
                                ConsoleManager.DisplayMessageOnConsole("Input only a, b");
                                break;
                        }
                        break;
                    case "c":
                        ConsoleManager.DisplayMessageOnConsole("Exit");
                        exit = true;
                        Wait();
                        break;
                    default:
                        ConsoleManager.DisplayMessageOnConsole("Input only a, b, c");
                        Wait();
                        break;
                }
                Console.Clear();
            }
        }
        private void SubMenu() 
        {
            ConsoleManager.DisplayMessageOnConsole("a - search by Name \n" +
            "b - search by Surname \n" +
            "c - search by Phone");
        }

        private void ShowConsoleMenu()
        {
            ConsoleManager.DisplayMessageOnConsole("a - Add contact");
            ConsoleManager.DisplayMessageOnConsole("b - Search contact by parametr");
            ConsoleManager.DisplayMessageOnConsole("c - Display all contacts");
            ConsoleManager.DisplayMessageOnConsole("d - remove contact");
        }

        private void ShowMenu()
        {
            ConsoleManager.DisplayMessageOnConsole("a - Console");
            ConsoleManager.DisplayMessageOnConsole("b - File");
            ConsoleManager.DisplayMessageOnConsole("c - exit");
        }

        private void FileMenu()
        {
            ConsoleManager.DisplayMessageOnConsole("a - Add contact");
            ConsoleManager.DisplayMessageOnConsole("b - Display all contacts");
        }

        private void Wait()
        {
            ConsoleManager.DisplayMessageOnConsole("Press any button");
            Console.ReadKey();
        }
    }
}
