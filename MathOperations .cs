using System;

public class MathOperations
{
    // Метод для додавання двох чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Метод для додавання двох масивів
    public static int[] Add(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }

        return result;
    }

    // Метод для додавання двох матриць
    public static int[,] Add(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows != b.GetLength(0) || cols != b.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return result;
    }

    // Аналогічно реалізуємо методи Subtract та Multiply для чисел, масивів та матриць
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int[] Subtract(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] - b[i];
        }

        return result;
    }

    public static int[,] Subtract(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows != b.GetLength(0) || cols != b.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }

        return result;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int[] Multiply(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] * b[i];
        }

        return result;
    }

    public static int[,] Multiply(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = b.GetLength(1);
        int innerDim = a.GetLength(1);

        if (innerDim != b.GetLength(0))
        {
            throw new ArgumentException("Matrices cannot be multiplied");
        }

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < innerDim; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }
}
