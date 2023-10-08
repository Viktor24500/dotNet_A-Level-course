namespace ArraysHW2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int minRange = -100;
            int maxRange = 100;
            int length;

            Console.WriteLine("Please input your number");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine($"length - {length}");
            if (length < 0 || length == null)
            {
                Console.WriteLine("Length should be >0");
                return;
            }
            if (length == 0)
            {
                Console.WriteLine("Your array is empty");
                return;
            }
            int[] finalArray = new int[length];
            finalArray = RandomArray(finalArray, minRange, maxRange);

            PrintArray(finalArray);
            Console.ReadKey();
        }
        public static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Array {i} --   {myArray[i]}");
            }
        }
        public static int[] RandomArray(int[] myArray, int minRange, int maxRange)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minRange, maxRange + 1);
            }
            return myArray;
        }
    }
}
