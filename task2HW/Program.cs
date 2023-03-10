// Напишите программу, которая 
// на вход принимает 2 числа
// и выдает, какое число
// большее
// какое - меньшее

// вариант решения 1
// Console.WriteLine("Введите два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} > {num2}"); 
// }
// else
// {
//     Console.WriteLine($"{num2} > {num1}");
// }

// вариант решения 2
// Console.WriteLine("Введите два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} больше, чем {num2}"); 
// }
// else
// {
//     Console.WriteLine($"{num2} больше, чем {num1}");
// }

// вариант решения 3
// Console.WriteLine("Введите два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine($"max = {num1}"); 
// }
// else
// {
//     Console.WriteLine($"max = {num2}");
// }

// вариант решения 4 (с дробными числами)
Console.WriteLine("Введите два числа");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"max = {num1}"); 
}
else
{
    Console.WriteLine($"max = {num2}");
}