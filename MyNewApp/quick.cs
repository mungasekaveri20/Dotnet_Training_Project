using System;

class Program90
{
    static void Main()
    {
        // Example array
        int[] array = { 10, 7, 8, 9, 1, 5 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Perform Quick Sort
        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    // Function to perform Quick Sort
    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Find the pivot element such that
            // elements smaller than pivot are on the left of pivot
            // elements greater than pivot are on the right of pivot
            int pi = Partition(array, low, high);

            // Recursively sort elements before and after partition
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    // Function to partition the array and find the pivot element
    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // Choose the rightmost element as pivot
        int i = (low - 1); // Pointer for greater element

        for (int j = low; j < high; j++)
        {
            // If current element is smaller than or equal to pivot
            if (array[j] <= pivot)
            {
                i++;
                // Swap array[i] and array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Swap array[i+1] and array[high] (or pivot)
        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
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
