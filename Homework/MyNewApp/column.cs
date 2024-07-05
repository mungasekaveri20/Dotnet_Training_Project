using System;

class Program321
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

        // Swap columns
        int col1 = 0; // first column (0-based index)
        int col2 = 2; // second column (0-based index)
        SwapColumns(matrix, col1, col2);

        Console.WriteLine("\nMatrix after swapping columns:");
        PrintMatrix(matrix);
    }

    // Function to swap two columns of a matrix
    static void SwapColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);

        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
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
