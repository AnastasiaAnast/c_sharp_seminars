﻿// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;

// Задаем целочисленную переменную numberDay
// если пользователь вводит 1 - консоль выдает "понедельник"
// если пользователь вводит 2 - консоль выдает "вторник"
// если пользователь вводит 3 - консоль выдает "среда"
// если пользователь вводит 4 - консоль выдает "четверг"
// если пользователь вводит 5 - консоль выдает "пятница"
// если пользователь вводит 6 - консоль выдает "суббота"
// если пользователь вводит 7 - консоль выдает "воскресенье"
// иначе - консоль выдает "такого дня недели не существует"

Console.WriteLine("Введите номер дня: ");
string numberDay = Console.ReadLine();
    if (numberDay == "1")
{
    Console.WriteLine("понедельник");
}
    else if (numberDay == "2")
{
    Console.WriteLine("вторник");
}
    else if (numberDay == "3")
{
    Console.WriteLine("среда");
}
   else if (numberDay == "4")
{
    Console.WriteLine("четверг");
}
   else if (numberDay == "5")
{
    Console.WriteLine("пятница");
}
    else if (numberDay == "6")
{
    Console.WriteLine("суббота");
}
    else if (numberDay == "7")
{
    Console.WriteLine("воскресенье");
}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}