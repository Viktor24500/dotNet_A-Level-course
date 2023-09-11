using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.HeroAndEnemy.Enemy
{
    public class Goblin : IUnit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public IWeapon Weapon { get; set; }

        public IArmour Armour { get; set; }

        public Goblin(string name, int attack, int health, IWeapon weapon, IArmour armour)
        {
            Name = name;
            health = health;
            attack = attack;
            int addAttack = weapon.GetAmountOfAddAttack();
            attack = attack + addAttack;
            int block = Block();
            int addBlock = armour.GetAmountOfAddBlock();
            block = block + addBlock;
        }

        public int Block()
        {
            return 15;
        }
    }
}
