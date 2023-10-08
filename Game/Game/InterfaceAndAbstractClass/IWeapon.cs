using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.InterfaceAndAbstractClass
{
    public interface IWeapon
    {
        public string Name { get; }
        public int AttackPower { get; }
        public int DefencePower { get; }

        void useWeapon();
    }
}
