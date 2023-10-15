namespace Module3_HW5_Task2_MultyThread
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first num");
            int.TryParse(Console.ReadLine(), out int firstNum);
            Console.WriteLine("Input second num");
            int.TryParse(Console.ReadLine(), out int secondNum);

            Task<int> factorial = Task.Run(() => Factorial.FactorialRecursion(firstNum));
            Task<int> fibonacci = Task.Run(() => Fibonacci.FibonacciMethod(secondNum));

            Task.WaitAll(factorial, fibonacci);
            var results = new List<(int Number, int Result)>
            {
                (firstNum, factorial.Result),
                (secondNum, fibonacci.Result)
            };
            Console.WriteLine("factorial");
            Console.WriteLine($"Number: {results[0].Number}, Result: {results[0].Result}");
            Console.WriteLine("fibonacci");
            Console.WriteLine($"Number: {results[1].Number}, Result: {results[1].Result}");
            Console.ReadKey();
        }
    }
}