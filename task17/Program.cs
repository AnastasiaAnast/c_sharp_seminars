// Напишите программу, которая 
// принимает на вход координаты точки (x, y), причем
// x ≠ 0 и y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0
                ? $"Указаннаые координаты соответствуют четверти -> {quarter}"
                : "Введены некорректные координаты";
Console.WriteLine(result);


int Quarter(int x, int y) //четверть
{
    if(x > 0 && y > 0) return 1; // 1-я четверть
    if(x < 0 && y > 0) return 2; // 1-я четверть
    if(x < 0 && y < 0) return 3; // 1-я четверть
    if(x > 0 && y < 0) return 4; // 1-я четверть
    return 0;
}

