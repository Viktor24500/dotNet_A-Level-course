using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Weapons
{
    public class Bow : IWeapon
    {
        public string Name
        {
            get => "Bow";
        }

        public int AttackPower
        {
            get => 13;
        }

        public int DefencePower
        {
            get => 0;
        }

        public void useWeapon()
        {
            Console.WriteLine($"{Name} attack");
        }
    }
}
