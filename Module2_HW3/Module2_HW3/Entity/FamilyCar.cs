using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3.Entity
{
    public class FamilyCar : Car
    {
        public bool Hybrid { get; set; }

        public FamilyCar(bool hybrid, int speed, string typeFuel, string brand, bool hasFourWheelDrive) : base(speed, typeFuel,
            brand, hasFourWheelDrive)
        {
            Hybrid = hybrid;
        }

        public override void Move()
        {
            Console.WriteLine("Family car moves");
        }
    }
}
