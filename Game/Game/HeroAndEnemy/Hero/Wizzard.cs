using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.HeroAndEnemy.Hero
{
    public class Wizzard : IAttack, IBlock
    {
        public string Name { get; set; }

        public IWeapon Weapon { get; set; }

        public IArmour Armour { get; set; }

        public Wizzard(string name, int attack, int block) 
        {
            Name = name;
            //attack = Attack();
            //attack = attack + Weapon.GetAmountOfAddAttack;
            //block = Block();
        }
        public int Attack()
        {
            return 5;
        }

        public int Block()
        {
            return 7;
        }
    }
}
