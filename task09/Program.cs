// 9. Напишите программу, которая 
// выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else 
    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int result = maxDigit(number);
    Console.WriteLine($"Наибольшая цифра числа -> {result}");
//АЛГОРИТМ СОЗДАНИЯ МЕТОДА: 1) определим тип возвращаемого значения для метода (целое число)
//2) название метода должно отражать выполняемую задачу
//3) в скобках передаем параметр(аргумент, исходные данные) - это исходные данные 
//для реализации алгоритма, указываем тип, сохраняем сюда значение, 
//которое передаем привызове метода
int MaxDigit(int num) // num = number (прим: 78)
{ //в теле метода реализуем сам алгоритм
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}

