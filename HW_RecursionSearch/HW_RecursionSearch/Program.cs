namespace HW_RecursionSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int searchNumber=-100;
            bool correctNumber = false;
            while (!correctNumber)
            {
                Console.WriteLine("Input your number");
                correctNumber = int.TryParse(Console.ReadLine(), out searchNumber);
                if (!correctNumber)
                {
                    Console.WriteLine("Please input integer number");
                    correctNumber = false;
                }
                else 
                {
                    correctNumber = true;
                }
            }
            int[] numbers = new int[] { -78, 29, 84, -61, -27, 3, 71, -52, -95,
            -4, 42, 68, -17, -67, -38, -85, -89, -56, -12, 95, 19, 5, 62, -50, 81, -33, -71, 11, 91, -7 };
            int findNumber=BinarySearch.Search(numbers, searchNumber);
            Console.WriteLine($"find number {findNumber}");
        }
    }
}