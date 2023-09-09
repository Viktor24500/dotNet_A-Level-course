using Module2_HW3.Entity;
using Module2_HW3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW3
{
    public class Data
    {
        //public IMove[] vehicles = new IMove[]
        public List<IMove> vehicles = new List<IMove>()
        {
                //loadCapacity, speed, typeFuel, brand, hasFourWheelDrive
                new Truck(5000, 80, "diesel", "Kraz", true),

                //numberOfSeat, speed, typeFuel, brand
                new Airplane(700, 965, "kerosene", "Boeing"),

                //hybrid, speed, typeFuel, brand, hasFourWheelDrive
                new FamilyCar(true, 120, "petrol", "Toyota", false),

                
                //speed, typeFuel, brand, hasFourWheelDrive
                new Car(130, "diesel", "Ford", true)
            };
    }
}
