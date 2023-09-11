using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Equipment.Weapons
{
    public class Maul : IWeapon
    {
        //A maul may refer to any number of large hammers
        public int GetAmountOfAddAttack()
        {
            return 10;
        }
    }
}
