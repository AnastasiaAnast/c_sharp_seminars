﻿// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7, обозначающее день недели, и узнайте, является ли этот день выходным");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <= 7)
{
    if(num > 5)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");

}
else Console.WriteLine("Такого дня в неделе не существует");