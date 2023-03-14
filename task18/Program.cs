// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string quarterNum = Console.ReadLine();

string result = Quarter(quarterNum);
Console.WriteLine(result);

string Quarter(string quarter) //четверть
{
    if(quarter == "1") return "x > 0 && y > 0"; // 1-я четверть
    if(quarter == "2") return "x < 0 && y > 0"; // 2-я четверть
    if(quarter == "3") return "x < 0 && y < 0"; // 3-я четверть
    if(quarter == "4") return "x > 0 && y < 0"; // 4-я четверть
    return "Введены некорректные координаты";
}
