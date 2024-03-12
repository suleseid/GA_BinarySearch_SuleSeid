
## 1.What is binary search and how does it work? 
````csharp 

. Binary search is a search algorithm that finds the position of a target value
  within a sorted array. It compares the target value to the middle element of the array;
  if they are not equal, it eliminates half of the array from consideration and 
  repeats the process on the remaining half until the target value is found or 
  the array cannot be split furthe
  
 Example:-
          Consider an array [2, 3, 4, 10, 40] and the target value is 10. 
          Binary search will start by comparing 10 with the middle element, 
          which is 4. Since 10 is greater, it ignores the left half and 
          repeats the process on the right half [10, 40]. 
          Now, 10 is compared with the middle element 10, 
          and since they are equal, the index 3 is returned.
````
## 2. What is the time complexity of binary search?

````csharp

  .The time complexity of binary search is ( O(\log n) ), 
   where ( n ) is the number of elements in the array. 
   This logarithmic time complexity occurs because the algorithm splits 
   the array in half with each iteration. 
   
   Example:-
         If you have 32 elements, binary search will take at most ( \log_2 32 = 5 ) 
         comparisons to find the target or conclude it’s not in the array.

````
## 3. When is binary search preferred over linear search? 

`````csharp

   . Binary search is preferred over linear search when dealing with large, sorted arrays 
     because it is significantly faster. Linear search has a time complexity of ( O(n) ), 
     making it less efficient for large datasets. 
       
       Example:-
             If you’re searching for a specific contact in a sorted list of thousands of contacts, 
             binary search will find it much quicker than linear search.
``````

## 4. What are the key requirements for binary search to work correctly? 
 
 ````csharp
  
  . The key requirement for binary search is that the array must be sorted in some order, 
    whether ascending or descending. Without a sorted array, the assumptions binary search makes 
    about the placement of elements are invalid. 
         Example:-
              If you have an array [3, 1, 4, 2] and you’re looking for the value 3, 
              binary search won’t work because the array isn’t sorted.

`````
## 5. Can binary search be applied to unsorted arrays? 

````csharp

 . Why or why not? Binary search cannot be applied to unsorted arrays because 
   it assumes the array is sorted to determine which half of the array contains the target value. 
   If the array is unsorted, this assumption is incorrect, and the algorithm will not function properly. 
        
        Example:-
              In an unsorted array [7, 2, 5, 3, 1], searching for the value 5 using binary search 
              could lead you to ignore the segment that contains 5, resulting in a failed search.
````
## We can apply  binary search to sort string arrays?
 ````csharp

   . Binary search can be applied to sorted string arrays just like it can be applied to sorted arrays of any comparable data type. 
     As long as the elements in the array are sorted in ascending order and can be compared using a comparison operator (e.g., <, >, ==),
     binary search can efficiently find a specific string within the array.

     Eample:-
           // Binary search function for sorted string array
    public static int BinarySearch(string[] array, string target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int comparisonResult = string.Compare(array[mid], target);

            // Check if target is present at mid
            if (comparisonResult == 0)
                return mid;

            // If target is greater, ignore left half
            if (comparisonResult < 0)
                left = mid + 1;
            // If target is smaller, ignore right half
            else
                right = mid - 1;
        }

        // If we reach here, then the element was not present
        return -1;
    }

    static void Main(string[] args)
    {
        string[] sortedArray = { "apple", "banana", "cherry", "grape", "orange" };
        string target = "cherry";

        int index = BinarySearch(sortedArray, target);
        if (index != -1)
            Console.WriteLine("Element found at index " + index);
        else
            Console.WriteLine("Element not found");
    }