using Module2_HW3.Entity;
using Module2_HW3.Interface;

namespace Module2_HW3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IMove> vehicles = new List<IMove>
            {
                //loadCapacity, speed, typeFuel, brand, hasFourWheelDrive
                new Truck(5000, 80, "diesel", "Kraz", true),
                //new Airplane(),
            };
        }
    }
}