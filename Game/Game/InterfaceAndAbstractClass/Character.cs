using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.InterfaceAndAbstractClass
{
    public abstract class Character : IWeapon
    {
        public IWeapon weapon;
        public string Name { get; set; }
        public int HealthAmount { get; set; }
        public int AttackAmount { get; set; }

        public int DefencePower => throw new NotImplementedException();

        public int AttackPower => throw new NotImplementedException();

        public Character(string name, int health, int attack)
        {
            Name = name;
            this.HealthAmount = health;
            this.AttackAmount = attack;
        }

        public virtual void Health() 
        {
            this.HealthAmount = HealthAmount + weapon.DefencePower;
        }

        public virtual void Attack(Character enemy)
        {
            this.AttackAmount = AttackAmount + weapon.AttackPower;
            enemy.HealthAmount = enemy.HealthAmount - this.AttackAmount;
        }

        public virtual void SetWeapon(IWeapon weaponInMethod)
        {
            this.weapon = weaponInMethod;
        }

        public virtual void Fight() 
        {
            Console.WriteLine($"{Name} attack");
        }

        public void useWeapon()
        {
            
        }
    }
}
