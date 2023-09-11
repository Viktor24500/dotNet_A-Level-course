using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Equipment.Weapons
{
    public class Bow : IWeapon
    {
        public int GetAmountOfAddAttack()
        {
            return 7;
        }
    }
}
