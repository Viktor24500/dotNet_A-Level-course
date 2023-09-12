using Module2_HW3.Entity;
using Module2_HW3.Interface;

namespace Module2_HW3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            //Sort by speed
            Console.WriteLine("Sort by speed");
            //List<IMove> sortedListBySpeed = (data.vehicles.OrderBy(item => item.Speed)).ToList();
            Array.Reverse(data.vehicles);
            foreach (var item in data.vehicles) 
            {
                Console.WriteLine($"{item.Brand}, {item.Speed}");
            }
            Console.WriteLine();
            //Sord by weight
            Console.WriteLine("Sort by descending brand length");
            IMove[] sortedArrayByBrand = (data.vehicles.OrderBy(x => x.Brand.Count())).ToArray();
            foreach (var item in sortedArrayByBrand)
            {
                Console.WriteLine($"{item.Brand}, {item.Speed}");
            }
            Console.WriteLine();

            //Find brand

            //Console.WriteLine("Input car brand");
            //string brand = Console.ReadLine();
            string brand = "Kraz";
            //IMove find = data.vehicles.Find(x => x.Brand == brand);
            IMove find =null;
            if (find == null) 
            {
                Console.WriteLine($"Car {brand} wasn`t found");
                return;
            }
            else if (find.Brand == brand)
            {
                Console.WriteLine($"Car {find.Brand} found");
            }
            Console.WriteLine(find.Brand);
            Console.ReadKey();
        }
    }
}