using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Characters
{
    public class Orc : Character
    {
        public IWeapon weapon;

        public string Name;
        public int Health;
        public int AttackAmount;

        public Orc(IWeapon weapon, string name, int health, int attack) : base(name, health, attack, weapon)
        {
            Name = name;
            Health = health;
            AttackAmount = attack;
            this.weapon = weapon;

        }

        //public override string Name 
        //{
        //    get => "Wizzard";
        //}

        //public override int Health 
        //{
        //    get => 30;
        //    //set => 30 + _weapon.Defence;
        //}

        //public override int Attack 
        //{
        //    get => 10;
        //}

        //public override void SetWeapon(IWeapon weaponInMethod)
        //{
        //    this.weapon = weaponInMethod;
        //}

        public override void Fight(Character enemy)
        {
            Console.WriteLine($"{this.Name} attack {enemy.Name}");
        }
    }
}
