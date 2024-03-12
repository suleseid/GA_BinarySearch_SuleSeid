using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GA_BinarySearch_SuleSeid
{
    public class BinarySearch
    {
        // Iterative binary search function for string array
        public static int IterativeBinarySearch(string[] array, string target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                int comparisonResult = string.Compare(array[mid], target);
                if (comparisonResult == 0)
                    return mid;

                // If target greater, ignore left half
                if (comparisonResult < 0)
                    left = mid + 1;
                // If target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // If we reach here, then the element was not present
            return -1;
        }

        // Recursive binary search function for string array
        public static int RecursiveBinarySearch(string[] array, string target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                int comparisonResult = string.Compare(array[mid], target);
                if (comparisonResult == 0)
                    return mid;

                // If target is smaller than mid, search left half
                if (comparisonResult > 0)
                    return RecursiveBinarySearch(array, target, left, mid - 1);

                // If target is greater than mid, search right half
                return RecursiveBinarySearch(array, target, mid + 1, right);
            }

            // If we reach here, then the element was not present
            return -1;
        }
    }
}

