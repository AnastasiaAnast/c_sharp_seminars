// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfNumbers = SumOfNumbers(number);

Console.WriteLine($"Сумма цифр в числе {number} = {sumOfNumbers}");

int SumOfNumbers(int num)
{
        int sum = 0;
    while(num != 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }

    return sum;
}