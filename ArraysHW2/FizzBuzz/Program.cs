namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator();
            Console.ReadKey();
        }
        public static void NumberGenerator()
        {
            int number = 0;
            while (number <= 100)
            {
                ifConditionTrue(number);
                number++;
            }
        }
        public static void ifConditionTrue(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"Number - {number} - FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine($"Number - {number} - Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine($"Number - {number} - Buzz");
            }
            else
            {
                Console.WriteLine($"Number - {number}");
            }
        }
    }
}
