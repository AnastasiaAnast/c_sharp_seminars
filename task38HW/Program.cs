// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

double[] CreateArrayDoubleNum(int size, int min, int max, int round = 1)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("Сейчас массив вещественных чисел такой - [");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceMaxMin(double max, double min)
{
    double dif = max - min;
    dif = Math.Round(dif, 1);
    return dif;
}

double[] array = CreateArrayDoubleNum(10, 0, 100, 1);
double maxElement = MaxElement(array);
double minElement = MinElement(array);
double diffMaxMin = DifferenceMaxMin(maxElement, minElement);

PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diffMaxMin}");