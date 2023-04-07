// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(number1, number2);

Console.WriteLine($"Число {number1} в степени {number2} = {degreeNumber}");

int DegreeNumber(int num1, int num2)
{
    int dnum = num1;
    if(num2 == 0) dnum = 1;
    
    for(int i = 1; i < num2; i++)
    {
        dnum = dnum * num1;
    }
    return dnum;
}