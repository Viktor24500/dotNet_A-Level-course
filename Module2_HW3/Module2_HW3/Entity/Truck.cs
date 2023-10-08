using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3.Entity
{
    public class Truck : Car
    {
        public int LoadCapacity { get; set; }

        public Truck(int loadCapacity, int speed, string typeFuel, string brand, bool hasFourWheelDrive) : base(speed, typeFuel,
    brand, hasFourWheelDrive)
        {
            LoadCapacity = loadCapacity;
        }

        public override void Move()
        {
            Console.WriteLine($"Truck moves");
        }
    }
}
