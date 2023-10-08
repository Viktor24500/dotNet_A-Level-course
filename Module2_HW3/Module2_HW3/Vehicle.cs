using Module2_HW3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public abstract class Vehicle : IMove
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public string TypeFuel { get; set; }

        public Vehicle(int speed, string typeFuel, string brand)
        {
            this.Brand = brand;
            this.Speed = speed;
            this.TypeFuel = typeFuel;
        }
        public abstract void Move();
    }
}
