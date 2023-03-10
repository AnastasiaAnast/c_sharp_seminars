// Напишите программу, которая 
// на вход принимает число и 
// выдает, явл ли оно четным (делится на 2 баз остатка)

Console.WriteLine ("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
if (num % 2 == 0)
{
Console.WriteLine($"указанное число является четным");
}
else
{
Console.WriteLine($"указанное число не является четным");
}