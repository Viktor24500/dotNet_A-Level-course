using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3.Entity
{
    public class Car : Vehicle
    {
        public bool HasFourWheelDrive { get; set; }
        public override void Move()
        {
            Console.WriteLine("Car moves");
        }
        public Car(int speed, string typeFuel, string brand, bool hasFourWheelDrive) : base(speed, typeFuel, brand)
        {
            HasFourWheelDrive = hasFourWheelDrive;
        }
    }
}
