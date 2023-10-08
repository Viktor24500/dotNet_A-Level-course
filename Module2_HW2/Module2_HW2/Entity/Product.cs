using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW2.Entity
{
    public class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Product(string prodName, int prodAmount)
        {
            Name = prodName;
            Amount = prodAmount;
        }
        public void InformationAboutProduct()
        {
            Console.WriteLine($"product - {Name}, Amount - {Amount}");
        }
    }
}
