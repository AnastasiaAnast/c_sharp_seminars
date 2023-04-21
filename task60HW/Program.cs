// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3dMatrix(int rows, int columns, int layers, int num)
{
    int[,,] arr3d = new int[rows, columns, layers];

    if (rows * columns * layers < 99)
    {
        for (int i = 0; i < arr3d.GetLength(0); i++)
        {
            for (int j = 0; j < arr3d.GetLength(1); j++)
            {
                for (int k = 0; k < arr3d.GetLength(2); k++)
                {
                    arr3d[i, j, k] = num++;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Слишком большой массив");
    }
    return arr3d;
}

void Print3dArray (int[,,] arr3d)
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {arr3d[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix3d = Create3dMatrix(2, 2, 2, 7);
Print3dArray(matrix3d);