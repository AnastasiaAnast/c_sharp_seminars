// Напишите программу, которая 
// принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(number);

Console.WriteLine($"Кол-во цифр в числе {number} - {countDigit}");

int CountDigit(int num)
{
    int count = 0;

    while (num != 0)
    {
        count++;
        num /= 10;
    }
    return count;
}