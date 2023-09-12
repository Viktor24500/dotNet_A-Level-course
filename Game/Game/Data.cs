using Game.Equipment.Armour;
using Game.Equipment.Weapons;
using Game.HeroAndEnemy.Enemy;
using Game.HeroAndEnemy.Hero;
using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Data
    {
        List<IWeapon> weapons = new List<IWeapon>
        {
            new Knife(),
            new Bow(),
            new HillAxe(),
            new Maul(),
            new Peak(),
            new Sword()
        };

        List<IArmour> armours = new List<IArmour>
        {
            new Shield(),
            new Helmet()
        };

        List<IUnit> heroes = new List<IUnit>
        {
            //new Warrior("Warrior", ),
            //new Wizzard()
        };

        List<IUnit> enemies = new List<IUnit>
        {
            new Goblin("Goblin", 40, 100, weapons ,armours),
            //new Wizzard()
        };
    }
}
