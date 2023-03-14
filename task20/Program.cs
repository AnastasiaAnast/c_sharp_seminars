// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Теорема пифагора: В прямоугольном треугольнике квадрат гипотенузы равен
// сумме квадратов двух других сторон (катетов).
// То есть, если a и b - катеты, а c - гипотенуза, то a 2 + b 2 = c 2 a^2 + b^2 = c^2

Console.WriteLine("Введите координаты двух точек");
Console.Write("xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, xB, yA, yB);
double resultRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"расстояние между двумя точками равно {resultRound}");

double Distance(int x1, int x2, int y1, int y2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return result;
}

// double d = Math.Sqrt(5);
// double res = 5.09987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);
