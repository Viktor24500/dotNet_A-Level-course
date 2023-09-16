using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Weapons
{
    public class Knife : IWeapon
    {
        public string Name
        {
            get => "Knife";
        }

        public int AttackPower
        {
            get => 5;
        }

        public int DefencePower
        {
            get => 3;
        }

        public void useWeapon()
        {
            Console.WriteLine($"{Name} attack");
        }
    }
}
