// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DelSecondNumber(int num)
{
    int firstNum = num / 100;
    int lastNum = num % 10;
    return firstNum * 10 + lastNum;
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int finalNum = DelSecondNumber(number);
Console.Write(finalNum);