using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Weapons
{
    public class Axe : IWeapon
    {
        public string Name 
        {
            get => "Axe";
        }

        public int AttackPower
        {
            get => 10;
        }

        public int DefencePower
        {
            get => 5;
        }

        public void useWeapon()
        {
            Console.WriteLine($"{Name} attack");
        }
    }
}
