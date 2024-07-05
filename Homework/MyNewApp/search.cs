using System;

class Program44
{
    static void Main()
    {
        // Example array
        int[] array = { 10, 20, 30, 40, 50 };
        
        // Element to search for
        int elementToSearch = 30;

        // Perform the search
        int index = SearchElement(array, elementToSearch);

        // Print the result
        if (index != -1)
        {
            Console.WriteLine("Element " + elementToSearch + " found at index " + index);
        }
        else
        {
            Console.WriteLine("Element " + elementToSearch + " not found in the array");
        }
    }

    // Function to search for an element in the array
    static int SearchElement(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                return i; // Element found at index i
            }
        }
        return -1; // Element not found
    }
}
