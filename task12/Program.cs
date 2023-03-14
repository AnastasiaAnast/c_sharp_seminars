// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите 1-ое целое положительное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое целое положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number1 % number2;

if (number3 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Не кратное");
}
Console.Write(number3);