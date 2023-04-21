// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void NaturalNumbers(int num)
{
    if(num < 1) return;
    Console.Write($"{num} ");
    NaturalNumbers (num - 1);
}

bool CheckNaturalNumber(int num)
{
    return num >= 1;
}

Console.WriteLine("Введите натуральное число, чтобы увидеть все натуральные числа от него до 1 включительно");
int number = Convert.ToInt32(Console.ReadLine());


if(CheckNaturalNumber(number))
{
    Console.Write($"Введенное число равняется ");
    NaturalNumbers(number);
}
else 
Console.Write($"Введенное число не является натуральным. ");