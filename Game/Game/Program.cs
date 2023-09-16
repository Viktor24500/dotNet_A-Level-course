using Game.Entity.Characters;
using Game.InterfaceAndAbstractClass;
using Game.Entity.Weapons;

namespace Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Axe axe = new Axe();
            //string a = axe.Name;
            //Console.WriteLine(a);
            Data data = new Data();
            data.characters[0].Stats();
            Console.WriteLine();
            data.characters[1].Stats();
            Console.WriteLine();
            //var healthBeforeAttack = data.characters[1].HealthAmount;
            //var amountAttack = data.characters[0].AttackAmount;
            data.characters[0].Fight(data.characters[1]);
            //data.characters[0].useWeapon();
            data.characters[0].Attack(data.characters[1]);
            //var healthAfterAttack = data.characters[1].HealthAmount;
            Console.ReadKey();
        }
    }
}