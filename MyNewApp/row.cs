using System;

class Program32
{
    static void Main()
    {
        // Example matrix
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Swap rows
        int row1 = 0; // first row (0-based index)
        int row2 = 2; // second row (0-based index)
        SwapRows(matrix, row1, row2);

        Console.WriteLine("\nMatrix after swapping rows:");
        PrintMatrix(matrix);
    }

    // Function to swap two rows of a matrix
    static void SwapRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
    }

    // Utility function to print a matrix
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
