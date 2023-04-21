﻿// Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] FindPoint(double number1, double number2, double number3, double number4)
{
    double x = (number3 - number1) / (number2 - number4);
    double y = number2 * x + number1;

    x = Math.Round(x, 1);
    y = Math.Round(y, 1);
    // Console.WriteLine(x);
    // Console.WriteLine(y);
    
    double[] point = new double[2];
    point[0] = x;
    point[1] = y;

    return point;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Чтобы найти точку пересечения двух прямых, введите четыре произвольных значения, нажимая enter после каждого: ");
Console.WriteLine("Введите значение b1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double num4 = Convert.ToDouble(Console.ReadLine());

double[] findPoint = FindPoint(num1, num2, num3, num4);

Console.WriteLine();
Console.Write($"Точка пересечения двух прямых имеет координаты "); PrintArray(findPoint);