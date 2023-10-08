using Module2_HW2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW2
{
    public class MenuService
    {
        private Store _store = new Store();

        private string _productString;
        private int _amount;
        private bool _containsProduct;

        public void Menu() 
        {
            bool exit = false;
            while (!exit) 
            {
                ShowMenu();
                Console.Write("Choose your option  ");
                string command = Console.ReadLine();
                switch (command) 
                {
                    case "a":
                        Console.WriteLine("Review products in storage");
                        _containsProduct=_store.ReviewStore();
                        Wait();
                        break;

                    case "b":
                        Console.WriteLine("Add product to storage");
                        Console.WriteLine("Input your product");
                        _productString = Console.ReadLine();
                        _amount = GetAmount();
                        _store.AddToStorage(new Product(_productString, _amount));
                        Console.WriteLine($"{_productString} added to storage");
                        Wait();
                        break;

                    case "c":
                        Console.WriteLine("Product in chart");
                        _store.ReviewShopingCart();
                        Wait();
                        break;

                    case "d":
                        Console.WriteLine("Add product to your cart");
                        Console.WriteLine("Input your product");
                        _productString = Console.ReadLine();
                        _amount = GetAmount();
                        _containsProduct = _store.AddToCart(new Product(_productString, _amount));
                        if (_containsProduct == true)
                        {
                            Console.WriteLine($"{_productString} added to chart");
                        }
                        else 
                        {
                            Console.WriteLine("You can't add this product to chart. Please  review store");
                        }
                        Wait();
                        break;

                    case "e":
                        Console.WriteLine("Remove product from your cart");
                        Console.WriteLine("Input your product");
                        _productString = Console.ReadLine();
                        _amount = GetAmount();
                        _containsProduct = _store.RemoveFromCart(new Product(_productString, _amount));
                        if (_containsProduct == true)
                        {
                            Console.WriteLine($"{_productString} removed from chart");
                        }
                        else
                        {
                            Console.WriteLine("You can't remove this product from chart. Please  review chart");
                        }
                        Wait();
                        break;

                    case "f":
                        Console.WriteLine("Confirm your chart");
                        _store.CartConfirmation();
                        Wait();
                        break;
                    case "g":
                        Console.WriteLine("Exit");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Your must write \"a, b, c, d, e, f, g\"");
                        break;
                }
                Console.Clear();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("a - review products in storage");
            Console.WriteLine("b - add product to storage");
            Console.WriteLine("c - review products in your chart");
            Console.WriteLine("d - add product to your chart");
            Console.WriteLine("e - remove product from your chart");
            Console.WriteLine("f - confirm your chart");
            Console.WriteLine("g - exit");
        }

        public int GetAmount() 
        {
            int amount = -100;
            bool checkValidation = false;
            while (!checkValidation) 
            {
                Console.WriteLine("Input your Amount");
                bool validation = int.TryParse(Console.ReadLine(), out amount);
                if (validation == true && amount>=0)
                {
                    checkValidation = true;
                }
                else 
                {
                    Console.WriteLine("You must enter digit >=0");
                    checkValidation = false;
                }
            }
            return amount;
        }
        private void Wait() 
        {
            Console.WriteLine("Press any button");
            Console.ReadKey();
        }

        
    }
}
