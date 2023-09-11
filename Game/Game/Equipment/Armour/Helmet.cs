using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interface;

namespace Game.Equipment.Armour
{
    public class Helmet : IArmour
    {
        public int GetAmountOfAddBlock()
        {
            return 5;
        }
    }
}
