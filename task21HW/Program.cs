﻿// Напишите программу, которая принимает
// на вход координаты двух точек и 
// находит расстояние между ними 
// в 3d пространстве

Console.WriteLine("Введите координаты двух точек, чтобы узнать расстояние между ними в 3d  пространстве");
Console.Write("Первая точка A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(distance);


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
    return resultRound;
}