using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3.Entity
{
    public class Airplane : Vehicle
    {
        public int NumberOfSeat { get; set; }
        public Airplane(int numberOfSeat, int speed, string typeFuel, string brand) : base(speed, typeFuel, brand)
        {
            this.NumberOfSeat = numberOfSeat;
        }
        public override void Move() 
        {
            Console.WriteLine("Airplane flight");
        }
    }
}
