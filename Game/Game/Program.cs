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
            data.characters[0].Fight(Orc);
        }
    }
}