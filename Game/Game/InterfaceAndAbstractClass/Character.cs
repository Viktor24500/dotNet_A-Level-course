using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.InterfaceAndAbstractClass
{
    public abstract class Character : IWeapon
    {
        public IWeapon Weapon;
        public string Name { get; set; }
        public int HealthAmount { get; set; }
        public int AttackAmount { get; set; }
        private bool _isAlive = true;

        public int DefencePower => Weapon.DefencePower;

        public int AttackPower => Weapon.AttackPower;

        public Character(string name, int health, int attack, IWeapon weapon)
        {
            Name = name;
            this.HealthAmount = health;
            this.AttackAmount = attack;
            this.Weapon = weapon;
        }

        public virtual void Health() 
        {
            this.HealthAmount = HealthAmount + Weapon.DefencePower;
        }

        public virtual void Attack(Character enemy)
        {
            this.AttackAmount = AttackAmount + Weapon.AttackPower;
            enemy.HealthAmount = enemy.HealthAmount - this.AttackAmount;

            if(IsAlive(enemy.HealthAmount) == false)
            {
                this._isAlive = false;
                return;
            }
        }

        public abstract void Fight(Character enemy);
        //{
        //    Console.WriteLine($"{this.Name} attack {enemy.Name}");
        //}

        public void useWeapon(IWeapon weapon)
        {
            Console.WriteLine($"Hero {this.Name} use {weapon.Name} and have {weapon.AttackPower} bonus to his attack " +
                $"and {weapon.DefencePower} for his defence");
        }

        public void useWeapon()
        {
            Console.WriteLine($"Hero {this.Name} use {Weapon.Name} and has {Weapon.AttackPower} bonus for " +
                $"attack and {Weapon.DefencePower} for defence");
        }

        public virtual void Stats() 
        {
            Console.WriteLine($"{Name} : \n" +
                $"Attack: {AttackAmount}, \n" +
                $"Defence: {HealthAmount}, \n" +
                $"Weapon: {Weapon.Name}, \n" +
                $"--------------- \n" +
                $"With bonus from weapons \n" +
                $"Attack: {AttackAmount + Weapon.AttackPower}, \n" +
                $"Defence: {HealthAmount + Weapon.DefencePower}");
        }

        public virtual bool IsAlive(int healthAmount)
        {
            if (healthAmount <= 0) 
            {
                Console.WriteLine($"{Name} dead");
                return false;
            }
            return true;
        }
    }
}
