using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Equipment.Armour
{
    public class Shield : IArmour
    {
        public int GetAmountOfAddBlock()
        {
            return 7;
        }
    }
}
