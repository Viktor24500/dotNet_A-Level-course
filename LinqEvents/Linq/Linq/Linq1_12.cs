using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Linq1_12
    {
        public static void LinqFrom1To12() 
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };
            List<string> strings = new List<string>() {"Abilities", "forfeited", "situation",
                "extremely", "my", "to", "he", "resembled", "Old", "had", "conviction",
                "discretion", "understood", "put", "principles", "you" };
            string str = "Abilities forfeited situation extremely my to he resembled." +
                " Old had conviction discretion understood put principles you.";

            var querry1 = numbers.Where(x => x%2==0 || x%3==0);
            var querry2 = numbers.Sum();
            var querry3 = numbers.Average();
            var querry4 = numbers.Max();
            var querry5 = numbers.Min();
            var querry6 = numbers.Where(x => x>10).Select(x=> x*10);
            var querry7 = str.Distinct();
            var querry8 = numbers.GroupBy(x => x).Select(group => new {x=group.Key, frequence = group.Count()});
            var querry9Even = numbers.Select(x => x % 2 == 0);
            var querry9Odd = numbers.Select(x => x % 2 == 1);
            Console.WriteLine($"Max in Even = {querry9Even.Max()}, max in Odd = {querry9Odd.Max()}");
            var querry10 = numbers.Select(x => x>numbers.Average());
            var querry11 = strings.GroupBy(x => x.Length);
            string subString = Console.ReadLine();
            var querry12 = strings.Where(str => str.Contains(subString, StringComparison.OrdinalIgnoreCase)).
                OrderBy(str => str.Length).Select(str => $"{char.ToUpper(str[0])}{str.Substring(1).ToLower()}");
            Console.WriteLine(querry1);
        }
    }
}
