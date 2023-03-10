// Напишите программу, которая 
// на вход принимает 3 числа и 
// выдает максимальное из этих чисел

Console.WriteLine("Введите три числа");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double num3 = Convert.ToDouble(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"max = {num1}"); 
}
else if ( num2 > num1 && num2 > num3)
{
    Console.WriteLine($"max = {num2}"); 
}
else
{
    Console.WriteLine($"max = {num3}");
}