using Game.InterfaceAndAbstractClass;
using Game.Entity.Weapons;
using Game.Entity.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Data
    {
        public static List<IWeapon> weapons = new List<IWeapon>
        {
            new Axe(),
            new Bow(),
            new Knife(),
            new Sword(),
        };
        
        public List<Character> characters = new List<Character> 
        {
            // weapon, name, health, attack
            new Troll(weapons[0], "Troll", 100, 15),
            new Orc(weapons[2], "Orc", 80, 20),
            new Wizzard(weapons[3], "Wizzard", 150, 25),
            new  Elv(weapons[1], "Elv", 60, 30)
        };
    }
}
