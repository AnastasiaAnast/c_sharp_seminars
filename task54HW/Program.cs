// Задайте двумерный массив. 
// Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.


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

void MatrixArrangeRow(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(1); z++)
            {
                if(matrix[i,j] <= matrix[i,z]) continue;

                temp = matrix[i,j];
                matrix[i,j] = matrix[i,z];
                matrix[i,z] = temp;
            }
            
        }
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2d);
Console.WriteLine();

MatrixArrangeRow(array2d);
PrintMatrix(array2d);