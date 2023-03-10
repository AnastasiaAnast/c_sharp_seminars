// Напишите программу, которая 
// принимает на вход трехзначное число и 
// на выходе показывает вторую цифру из этого числа

Console.WriteLine ("Введите трехзначное число, чтобы увидеть вторую цифру из данного числа. Обратите внимание, что если число будет не трехзначным, программа работать не будет.");

int SecondDigitOfAThreeDigitNumber(int num)
{
    int firstStep = num / 10;
    int lastStep = firstStep % 10;
    return lastStep;
}

int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999) 
{
    int solution = SecondDigitOfAThreeDigitNumber(num);
    Console.WriteLine($"Вторая цифра введенного числа {num} - {solution}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}

