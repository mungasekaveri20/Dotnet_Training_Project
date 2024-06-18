using System;

class Program34
{
    static void Main()
    {
        // Example array
        int[] array = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Given Array:");
        PrintArray(array);

        // Perform merge sort
        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    // Function to perform merge sort
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int mid = (left + right) / 2;

            // Sort first and second halves
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            // Merge the sorted halves
            Merge(array, left, mid, right);
        }
    }

    // Function to merge two subarrays of array[]
    static void Merge(int[] array, int left, int mid, int right)
    {
        // Find sizes of two subarrays to be merged
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        // Merge the temporary arrays

        // Initial indexes of first and second subarrays
        int i1 = 0, i2 = 0;

        // Initial index of merged subarray array
        int k = left;
        while (i1 < n1 && i2 < n2)
        {
            if (leftArray[i1] <= rightArray[i2])
            {
                array[k] = leftArray[i1];
                i1++;
            }
            else
            {
                array[k] = rightArray[i2];
                i2++;
            }
            k++;
        }

        // Copy remaining elements of leftArray[], if any
        while (i1 < n1)
        {
            array[k] = leftArray[i1];
            i1++;
            k++;
        }

        // Copy remaining elements of rightArray[], if any
        while (i2 < n2)
        {
            array[k] = rightArray[i2];
            i2++;
            k++;
        }
    }

    // Utility function to print an array
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
