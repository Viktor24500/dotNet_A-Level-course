using Module2_HW2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW2
{
    public class Store
    {
        private ShopingCart _shoppingCart = new ShopingCart();
        private List<Product> _listProducts = new List<Product>();

        public Store() 
        {
            AddDataToStorage();
        }

        public int FindIndexInStorage(Product product)
        {
            for (int i = 0; i < _listProducts.Count(); i++)
            {
                if (_listProducts[i].Name == product.Name)
                {
                    return i;
                }
            }
            return -100;
        }
        public void AddToStorage(Product product)
        {
            int index = FindIndexInStorage(product);
            if (index >= 0)
            {
                _listProducts[index].Amount = _listProducts[index].Amount + product.Amount;
            }
            else 
            {
                _listProducts.Add(product);
            }
        }

        public bool RemoveFromStorage(Product product)
        {
            int index = FindIndexInStorage(product);
            if (index >= 0)
            {
                if (_listProducts[index].Amount < product.Amount)
                {
                    Console.WriteLine("You can't remove this product. Please  review store");
                    return false;
                }
                _listProducts[index].Amount = _listProducts[index].Amount - product.Amount;
                return true;
            }
            else
            {
                Console.WriteLine("You can't remove this product. Please  review store");
                return false;
            }
        }

        public bool ReviewStore() 
        {
            if (_listProducts.Count == 0) 
            {
                return false;
            }
            foreach (var item in _listProducts) 
            {
                Console.WriteLine($"Name {item.Name}, Amount {item.Amount}");
            }
            return true;
        }

        public bool AddToCart(Product products)
        {
            bool flag =_shoppingCart.AddToCart(products);
            return flag;
        }

        public bool RemoveFromCart(Product products)
        {
            bool flag = _shoppingCart.RemoveFromCart(products);
            return flag;
        }

        public void CartConfirmation()
        {
            _shoppingCart.CartConfirmation();
        }

        public void ReviewShopingCart()
        {
            _shoppingCart.DisplayShopingCart();
        }

        private void AddDataToStorage()
        {
            Product product1 = new Product("keyboard", 10);
            Product product2 = new Product("TV", 20);
            Product product3 = new Product("display", 30);
            Product product4 = new Product("PC", 5);
            Product product5 = new Product("DVD", 12);
            Product product6 = new Product("CD", 50);
            Product product7 = new Product("Microphone", 15);

            AddToStorage(product1);
            AddToStorage(product2);
            AddToStorage(product3);
            AddToStorage(product4);
            AddToStorage(product5);
            AddToStorage(product6);
            AddToStorage(product7);
        }

        private class ShopingCart
        {
            private Store _store;
            public List<Product> _shoppingCart = new List<Product>();

            public bool AddToCart(Product product)
            {
                bool validationFlag = ValidateItemCount();
                if (validationFlag == false) 
                {
                    Console.WriteLine("You reach max amount of cart (10)");
                    return false;
                }
                int indexInStorage = _store.FindIndexInStorage(product);
                int indexInShopingCart = FindIndexInShopingCart(product);
                if (indexInStorage >= 0 && indexInShopingCart>=0)
                {
                    if (_store._listProducts[indexInStorage].Amount < product.Amount)
                    {
                        return false;
                    }
                    _shoppingCart[indexInShopingCart].Amount = _shoppingCart[indexInShopingCart].Amount+product.Amount;
                    _store._listProducts[indexInStorage].Amount = _store._listProducts[indexInStorage].Amount - product.Amount;
                    return true;
                }
                else if(indexInStorage >= 0 && indexInShopingCart < 0)
                {
                    if (_store._listProducts[indexInStorage].Amount < product.Amount)
                    {
                        return false;
                    }
                    _store._listProducts[indexInStorage].Amount = _store._listProducts[indexInStorage].Amount - product.Amount;
                    _shoppingCart.Add(product);
                    return true;
                }
                return false;
            }

            public int FindIndexInShopingCart(Product product)
            {
                for (int i = 0; i < _shoppingCart.Count(); i++)
                {
                    if (_shoppingCart[i].Name == product.Name)
                    {
                        return i;
                    }
                }
                return -100;
            }

            public bool RemoveFromCart(Product product)
            {
                int indexInStorage = _store.FindIndexInStorage(product);
                int indexInShopingCart = FindIndexInShopingCart(product);
                if (indexInStorage >= 0 && indexInShopingCart >= 0)
                {
                    if (_shoppingCart[indexInShopingCart].Amount < product.Amount)
                    {
                        return false;
                    }
                    _shoppingCart[indexInShopingCart].Amount = _shoppingCart[indexInShopingCart].Amount - product.Amount;
                    _store._listProducts[indexInStorage].Amount = _store._listProducts[indexInStorage].Amount + product.Amount;
                    return true;
                }
                else 
                {
                    return false;
                }
            }

            public void DisplayShopingCart()
            {
                if (_shoppingCart.Count == 0)
                {
                    Console.WriteLine("cart is empty");
                }
                foreach (var item in _shoppingCart)
                {
                    Console.WriteLine($"Name {item.Name}, Amount {item.Amount}");
                }
            }

            public void CartConfirmation()
            {
                string numberCart = "A180";
                Console.WriteLine("Do you confirm your chart?");
                Console.WriteLine("Press Y for Yes");
                string confirmation = Console.ReadLine();
                if (confirmation == "Y")
                {
                    Random randomNumber = new Random();
                    int numberOfOrder = randomNumber.Next(0, 300);
                    if (_shoppingCart.Count == 0)
                    {
                        Console.WriteLine("cart is empty");
                    }
                    numberCart = numberCart + numberOfOrder.ToString();
                    Console.WriteLine(numberCart);
                    foreach (var item in _shoppingCart)
                    {
                        Console.WriteLine($"Name {item.Name}, Amount {item.Amount}");
                    }
                    _shoppingCart.Clear();
                }
            }

            public bool ValidateItemCount() 
            {
                int count = 0;
                foreach (var item in _shoppingCart) 
                {
                    count = count + item.Amount;
                }
                if (count >= 10) 
                {
                    return false;
                }
                return true;
            }
        }
    }
}
