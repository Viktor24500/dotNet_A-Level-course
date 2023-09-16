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

        public int DefencePower => throw new NotImplementedException();

        public int AttackPower => throw new NotImplementedException();

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
        }

        //public virtual void SetWeapon(IWeapon weaponInMethod)
        //{
        //    this.weapon = weaponInMethod;
        //}

        public virtual void Fight(Character enemy) 
        {
            Console.WriteLine($"{this.Name} attack {enemy.Name}");
        }

        public void useWeapon()
        {
            
        }
    }
}
