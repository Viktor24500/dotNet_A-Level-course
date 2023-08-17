namespace HW2_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = 20;
            int counter = 0;
            int[] startArray = new int[length];
            //int[] finalArray = new int[length];
            startArray = RandomArray(startArray, length);
            for (int i = 0; i < length; i++)
            {
                if (startArray[i] <= 888)
                {
                    counter++;
                }
            }
            int[] finalArray = new int[counter];
            finalArray = CopyArray(startArray, finalArray);
            //finalArray =SortArray(finalArray);
            Console.WriteLine("old array");
            PrintArray(startArray);
            Console.WriteLine();
            Console.WriteLine("new array after");
            PrintArray(finalArray);
            Console.ReadKey();
        }
        public static int[] RandomArray(int[] myArray, int length)
        {
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                myArray[i] = random.Next(2000);
            }
            return myArray;
        }
        public static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Array {i} --   {myArray[i]}");
            }
        }
        public static int[] CopyArray(int[] startArray, int[] finalArray)
        {
            int j = 0;
            for (int i = 0; i < startArray.Length; i++)
            {
                if (startArray[i] <= 888)
                {
                    finalArray[j] = startArray[i];
                    j++;
                }
            }
            ////Length finalArray=20
            //for (int i = 0; i < startArray.Length; i++)
            //{
            //    if (startArray[i] <= 888)
            //    {
            //        finalArray[i] = startArray[i];
            //    }
            //    else
            //    {
            //        finalArray[i] = 0;
            //    }
            //}
            Array.Sort(finalArray);
            Array.Reverse(finalArray);
            return finalArray;
        }
    }
}
