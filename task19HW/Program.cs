// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

bool Palindrome(int number)
{
    if(number < 10) 
    return false;

    int initialNumber = number;
    int reversedNumber = 0;

    while(number > 0)
    {
        reversedNumber = reversedNumber * 10 + number % 10;
        number /= 10;
    }
    return initialNumber == reversedNumber;
}

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) 
num = num * -1;

bool palindrome = Palindrome(num);
Console.WriteLine(palindrome ? "Введенное число является палиндромом" : "Введенное число не является палиндромом");
