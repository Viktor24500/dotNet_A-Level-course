namespace Hw4_Module
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[,] itemsArray = new string[2, 10]; //row, columns
            string[,] itemsArray = new string[2, 10]
            {
                {"buy bread","s","d","f","g","h","j","k","l","o" },
                {"0","0","1 22/08/2023 21:31", "0", "0", "1 22/08/2023 21:31", "1 22/08/2023 21:31", "0",
                    "1 22/08/2023 21:31", "1 22/08/2023 21:31"  }
            };
            Menu(ref itemsArray);
        }

        public static void Menu(ref string[,] itemsArray) 
        {
            bool exit = false;
            while (!exit) 
            {
                ShowMenu();
                Console.WriteLine("Choose option");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        Console.WriteLine("add-item");
                        AddItem(ref itemsArray);
                        Console.WriteLine("Enter any key");
                        Console.ReadKey();
                        break;
                    case "b":
                        Console.WriteLine("remove-item");
                        RemoveItem(ref itemsArray);
                        Console.WriteLine("Enter any key");
                        Console.ReadKey();
                        break;
                    case "c":
                        Console.WriteLine("mark-as");
                        MarkAs(ref itemsArray);
                        Console.WriteLine("Enter any key");
                        Console.ReadKey();
                        break;
                    case "d":
                        Console.WriteLine("show");
                        ShowItems(ref itemsArray);
                        Console.WriteLine("Enter any key");
                        Console.ReadKey();
                        break;
                    case "e":
                        Console.WriteLine("exit");
                        exit = true;
                        Console.WriteLine("Enter any key");
                        Console.ReadKey();
                        break;
                    default: Console.WriteLine("Please enter correct position from menu (a, b, c, d, e");
                            Console.WriteLine("Enter any key");
                            Console.ReadKey();
                            break;
                }
                Console.Clear();
            }
        }

        public static void ShowMenu() 
        {
            Console.WriteLine("a - Add item");
            Console.WriteLine("b - Remove item");
            Console.WriteLine("c - Mark as");
            Console.WriteLine("d - Show items");
            Console.WriteLine("e - exit");
        }

        public static void AddItem(ref string[,] itemsArray) 
        {
            Console.WriteLine("Enter your item");
            string item = Console.ReadLine();
            bool check = CheckItemInArray(ref itemsArray, item);
            if (check == true)
            {
                Console.WriteLine($"Item - {item} already exist");
            }
            else 
            {
                AddItemInArray(ref itemsArray, item);
                Console.WriteLine($"Item - {item} add");
            }
        }

        public static void RemoveItem(ref string[,] itemsArray)
        {
            Console.WriteLine("Enter your item or *");
            string item = Console.ReadLine();
            if (item == "*")
            {
                Array.Clear(itemsArray, 0, itemsArray.Length);
                Console.WriteLine("Array clear");
            }
            else 
            {
                bool check = RemoveItemInArray(ref itemsArray, item, "Remove");
                if (check == true)
                {
                    Console.WriteLine($"Item - {item} removed");
                }
                else 
                {
                    Console.WriteLine($"Item - {item} don't exist");
                }
            }
        }

        public static void MarkAs(ref string[,] itemsArray)
        {
            Console.WriteLine("Enter your item");
            string item = Console.ReadLine();
            Console.WriteLine("Enter your status");
            string status = Console.ReadLine();
            if (status != "0" && status != "1")
            {
                Console.WriteLine("incorect status");
                return;
            }
            else if (status == "1") 
            {
                Console.WriteLine("Enter your date or press Enter");
                string date = Console.ReadLine();
                if (date == "") 
                {
                    DateTime dateT = DateTime.Now;
                    date = dateT.ToString("dddd, dd MMMM yyyy");
                }
                status = status + " " + date;
                Console.WriteLine($"status {status}");
            }

            bool checkItem = CheckItemInArray(ref itemsArray, item);
            if (checkItem == true)
            {
                ChangeStatusItemInArray(ref itemsArray, item, status);
                Console.WriteLine($"{item} status changed to {status}");
                return;
            }
            else 
            {
                Console.WriteLine($"Item - {item} don't exist");
            }
        }

        public static void ShowItems(ref string[,] itemsArray)
        {
            Console.WriteLine("Enter your status");
            string status = Console.ReadLine();
            if (status != "0" && status != "1" && status!="")
            {
                Console.WriteLine("incorect status");
                return;
            }
            ShowItemsFromArray(ref itemsArray, status);
        }

        public static bool CheckItemInArray(ref string[,] itemsArray, string item)
        {
            int rows = itemsArray.GetUpperBound(0) + 1;
            int columns = itemsArray.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string curentItem = itemsArray[i, j];
                    if ((itemsArray[i, j] == null) && (itemsArray[i+1, j] == null))
                    {
                        continue;
                    }
                    else if ((curentItem.ToUpper() == item.ToUpper()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ChangeStatusItemInArray(ref string[,] itemsArray, string item
            , string status = "0")
        {
            int rows = itemsArray.GetUpperBound(0) + 1;
            int columns = itemsArray.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string curentItem = itemsArray[i, j];
                    if (itemsArray[i, j] == null)
                    {
                        continue;
                    }
                    else if (curentItem.ToUpper() == item.ToUpper())
                    {
                        itemsArray[i + 1, j] = status;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool RemoveItemInArray(ref string[,] itemsArray, string item,
            string indicateAddOrRemoveOrChangeStatus, string status = "0")
        {
            int rows = itemsArray.GetUpperBound(0) + 1;
            int columns = itemsArray.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string curentItem = itemsArray[i, j];
                    if (itemsArray[i, j] == null) 
                    {
                        continue;
                    }
                    else if (curentItem.ToUpper() == item.ToUpper())
                    {
                        itemsArray[i, j] = null;
                        itemsArray[i + 1, j] = null;
                        return true;
                    }
                }
            }
            return false;
        }

        public static void ShowItemsFromArray(ref string[,] itemsArray, string status) 
        {
            int rows = itemsArray.GetUpperBound(0) + 1;
            int columns = itemsArray.Length / rows;
            string[] SymbolInSecondLineInArray = new string[status.Length];
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((itemsArray[i, j] == null) && (itemsArray[i + 1, j] == null))
                    {
                        continue;
                    }
                    else if ( (itemsArray[i+1, j].Length > 1) && (status=="1")) // status = 1
                    {
                        SymbolInSecondLineInArray = itemsArray[i + 1, j].Split(' ');
                        string statusFromArray = SymbolInSecondLineInArray[0];
                        if (statusFromArray == status) 
                        {
                            Console.WriteLine($"Item - {itemsArray[i, j]}, status - {itemsArray[i + 1, j]}");
                        }
                    }
                    else if (itemsArray[i + 1, j] == status) //status = 0
                    {
                        Console.WriteLine($"Item - {itemsArray[i, j]}, status - {itemsArray[i + 1, j]}");
                    }
                    else if (status=="") //status = ""
                    {
                        Console.WriteLine($"Item - {itemsArray[i, j]}, status - {itemsArray[i + 1, j]}");
                    }
                }
            }
        }

        public static bool AddItemInArray(ref string[,] itemsArray, string item)
        {
            int rows = itemsArray.GetUpperBound(0) + 1;
            int columns = itemsArray.Length / rows;
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((itemsArray[i, j] == null) && (itemsArray[i + 1, j] == null))
                    {
                        itemsArray[i, j] = item;
                        itemsArray[i + 1, j] = "0";
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool SearchFreeSpaceInArray(ref string[,] itemsArray, string item)
        {
            int counterFreeSpace = 0;
            int rows = itemsArray.GetUpperBound(0) + 1;
            int columns = itemsArray.Length / rows;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((itemsArray[i, j] == null) && (itemsArray[i + 1, j] == null))
                    {
                        counterFreeSpace++;
                    }
                }
            }
            //if (counterFreeSpace < 2) 
            //{
            //    Array.Resize(ref itemsArray, (2,10));
            //}
            return false;
        }
    }
}