using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Characters
{
    public class Wizzard : Character
    {
        private IWeapon _weapon;

        public Wizzard(string name, int health, int attack) : base(name, health, attack)
        {
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

        public override void SetWeapon(IWeapon weaponInMethod)
        {
            this._weapon = weaponInMethod;
        }
    }
}
