using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.HeroAndEnemy.Hero
{
    public class Warrior : IUnit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public IWeapon Weapon { get; set; }

        public IArmour Armour { get; set; }

        public Warrior(string name, int block, int health, int attack)
        {
            Name = name;
            Health = health;
            attack = attack;
            //attack = Attack();
            //attack = attack + Weapon.GetAmountOfAddAttack;
            //block = Block();
        }

        public int Block()
        {
            return 15;
        }
    }
}
