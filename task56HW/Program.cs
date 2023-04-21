// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 3} ");
    }
    Console.WriteLine("|");
    }
}

int MatrixRowMinSum(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
        Console.WriteLine($"Сумма чисел в {i + 1}-строке = {sumRow[i]}");
    }
    
    int sum = sumRow[0];
    int minRow = 0;

    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < sum)
        {
            sum = sumRow[i];
            minRow = i;
        }
    }
    return minRow + 1;
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();

int minRowIndex = MatrixRowMinSum(array2d);
Console.WriteLine();
Console.WriteLine($"Строка с найменьшей суммой элементов - {minRowIndex}");