namespace HW_RecursionSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int searchNumber = -100;
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
            int[] numbers = new int[] { -95, -89, -85, -78, -71, -67, -61, -56, -52, -50, -38, -33,
                -27, -17, -12, -7, -4, 3, 5, 11, 19, 29, 42, 62, 68, 71, 81, 84, 91, 95 };
            checkSortArray(numbers);
            int findNumber = BinarySearch.Search(numbers, searchNumber);
            Console.WriteLine($"find number in {findNumber} index");
        }

        private static void checkSortArray(int[] numbers) 
        {
            int left = 0;
            int right = 1;
            for(int i=0; i<numbers.Length; i++) 
            {
                if (numbers[left] > numbers[right])
                {
                    throw new ArgumentException($"Array doesn't sort");
                }
                left++;
                if (right < numbers.Length - 1)
                {
                    right++;
                }
            }
        }
    }
}