// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Numbers (int n)
{
    int[] arr = new int[n];
    Console.WriteLine("Введите несколько чисел, нажимая enter после каждого введенного числа");
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}


void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Введите произвольное кол-во чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = Numbers(m);
int countNumbers = CountNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine($" Вы ввели следующее кол-во чисел, значение которых больше 0: {countNumbers}");