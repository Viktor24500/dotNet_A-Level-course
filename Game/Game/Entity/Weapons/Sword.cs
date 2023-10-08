using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Weapons
{
    public class Sword : IWeapon
    {
        public string Name
        {
            get => "Sword";
        }

        public int AttackPower
        {
            get => 15;
        }

        public int DefencePower
        {
            get => 10;
        }

        public void useWeapon()
        {
            Console.WriteLine($"{Name} attack");
        }
    }
}
