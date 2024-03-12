using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BinarySearch_SuleSeid
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Example usage of BinarySearch class

            string[] sampleArray = { "apple", "banana", "cherry", "grape", "orange" }; // Sample sorted array
            string targetValue = "cherry"; // Target value to search for

            // Using iterative binary search
            int iterativeResult = BinarySearch.IterativeBinarySearch(sampleArray, targetValue);
            if (iterativeResult != -1)
                Console.WriteLine("Iterative Binary Search: Element found at index " + iterativeResult);
            else
                Console.WriteLine("Iterative Binary Search: Element not found");

            // Using recursive binary search
            int recursiveResult = BinarySearch.RecursiveBinarySearch(sampleArray, targetValue, 0, sampleArray.Length - 1);
            if (recursiveResult != -1)
                Console.WriteLine("Recursive Binary Search: Element found at index " + recursiveResult);
            else
                Console.WriteLine("Recursive Binary Search: Element not found");
        }
    }
    
}
