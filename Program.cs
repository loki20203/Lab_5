class Program
{
    static void Main()
    {
        // Додавання чисел
        int numResult = MathOperations.Add(5, 3);
        Console.WriteLine($"Add(5, 3) = {numResult}");

        // Додавання масивів
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] arrayResult = MathOperations.Add(array1, array2);
        Console.WriteLine("Add([1, 2, 3], [4, 5, 6]) = [" + string.Join(", ", arrayResult) + "]");

        // Додавання матриць
        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        int[,] matrix2 = {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };
        int[,] matrixResult = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Add(Matrix1, Matrix2) = ");
        for (int i = 0; i < matrixResult.GetLength(0); i++)
        {
            for (int j = 0; j < matrixResult.GetLength(1); j++)
            {
                Console.Write(matrixResult[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
