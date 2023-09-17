using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Menu
    {
        Data data = new Data();

        public void ShowMenu()
        {
            Console.WriteLine("a - play for Wizzard ");
            Console.WriteLine("b - play for Elv ");
            Console.WriteLine("c - Exit");
        }

        public void Start() 
        {
            bool exit = false;
            while (!exit) 
            {
                ShowMenu();
                Console.WriteLine("Input your choice: ");
                string choice = Console.ReadLine();
                switch (choice) 
                {
                    case "a":
                    {
                        ChooseEnemy(1);
                        Wait();
                        
                            break;
                    }
                    case "b":
                    {
                        ChooseEnemy(2);
                        Wait();
                        break;
                    }
                    case "c":
                    {
                        exit = true;
                        Wait();
                        break;
                    }
                    default: 
                    {
                        Console.WriteLine("Incorrect choice (a, b ,c)");
                        Wait();
                        break;
                    }
                }
                Console.Clear();
            }
        }

        public void Wait() 
        {
            Console.WriteLine("Input something");
            Console.ReadKey();
        }

        public void ChooseEnemy(int flag)
        {
            Random random = new Random();
            int randomEnemy = random.Next(0, 1); // Random choice between Troll and Orc
            Fight(flag, randomEnemy);
        }

        public void Fight(int flag, int randomEnemy)
        {
            bool isAlive ;
            if (flag == 1) //Wizzard
            {
                // attack -> false - Enemy dead, Attack -> true - Enemy alive
                while (data.characters[2].HealthAmount > 0 && data.characters[randomEnemy].HealthAmount > 0)
                {
                    data.characters[2].Fight(data.characters[randomEnemy]);
                    isAlive=data.characters[2].Attack(data.characters[randomEnemy]);
                    if (isAlive == false) 
                    {
                        return;
                    }
                    data.characters[randomEnemy].Fight(data.characters[2]);
                    isAlive = data.characters[randomEnemy].Attack(data.characters[2]);
                    CheckIsAlive(data.characters[2], isAlive);
                    if (isAlive == false)
                    {
                        return;
                    }
                }
            }
            else 
            {
                // attack -> false - Enemy dead, Attack -> true - Enemy alive
                while (data.characters[3].HealthAmount > 0 && data.characters[randomEnemy].HealthAmount > 0)
                {
                    data.characters[3].Fight(data.characters[randomEnemy]);
                    isAlive = data.characters[3].Attack(data.characters[randomEnemy]);
                    if (isAlive == false)
                    {
                        return;
                    }
                    data.characters[randomEnemy].Fight(data.characters[3]);
                    isAlive = data.characters[randomEnemy].Attack(data.characters[3]);
                    if (isAlive == false)
                    {
                        return;
                    }
                }
            }
        }
        public void CheckIsAlive(Character character, bool isAlive) 
        {
            if (isAlive == true) 
            {
                return;
            }
            return;
        }
    }
}
