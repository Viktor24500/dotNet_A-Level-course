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
            new Troll(weapons[new Random().Next(0, 4)], "Troll", 100, 15),
            new Orc(weapons[new Random().Next(0, 4)], "Orc", 80, 20),
            new Wizzard(weapons[new Random().Next(0, 4)], "Wizzard", 100, 15),
            new  Elv(weapons[new Random().Next(0, 4)], "Elv", 60, 30)
        };
    }
}
