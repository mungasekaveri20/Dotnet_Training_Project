
using System;

class Program77
{
    static void Main()
    {
        // Example array
        int[] array = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Perform Selection Sort
        SelectionSort(array);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    // Function to perform Selection Sort
    static void SelectionSort(int[] array)
    {
        int n = array.Length;

        // One by one move the boundary of the unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element of the unsorted array
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    // Utility function to print the array
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
