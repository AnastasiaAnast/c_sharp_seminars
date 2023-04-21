// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов 
// в промежутке от M до N.

bool CheckNaturalNumber(int num)
{
    return num >= 1;
}

int SumNumbers(int num1, int num2)
{
    if(num1 == num2) return num2;
    {
        if(num1 < num2)
        return num1 + SumNumbers(num1 + 1, num2);
        else
        return num1 + SumNumbers(num1 - 1, num2);
    }
}

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number1, number2);

if(CheckNaturalNumber(number1) && CheckNaturalNumber(number2))
{
    Console.WriteLine($"M = {number1}; N = {number2} -> {sumNumbers}");
}
else 
{
    Console.WriteLine("Введенные числа (или одно из них) не являются натуральными");
}