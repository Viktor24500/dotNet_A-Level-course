using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_RecursionSearch
{
    public class BinarySearch
    {
        public static int Search(int[] numbers, int searchItem) 
        {
            if (!numbers.Contains(searchItem)) 
            {
                throw new ArgumentException($"Array doesn't contain {searchItem}");
            }
            int left = 0;
            int right = numbers.Length-1;
            while (left < right) 
            {
                int mid = (left + right) / 2;
                if (numbers[mid]==searchItem)
                { 
                    return mid;
                }
                else if (searchItem > numbers[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right= mid - 1;
                }
            }
            return -1;
        }
    }
}
