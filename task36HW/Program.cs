// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("Сейчас одномерный массив, заполненный случайными числами такой - [");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumElemOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreateArray(19, 0, 28);
PrintArray(array);
Console.WriteLine();
int sumElemOddPosition = SumElemOddPosition(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumElemOddPosition}");