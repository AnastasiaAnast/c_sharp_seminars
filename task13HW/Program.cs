// Напишите программу, которая
// выводит 3-ю цифру заданного числа или 
// сообщает, что третьей цифры нет

//цикл /10 пока не получим трехзначное число, далее выводим 3-ю цифру

// <= 100 && >= 999

Console.WriteLine ("Введите число, чтобы увидеть третью цифру из данного числа (или ее отсутствие)");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdNumber(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}

if(number < 0) number = -number;
if(ThirdNumber(number) == -1)
Console.WriteLine("Третьей цифры у данного числа нет");
else
{
Console.WriteLine($"Третья цифра у данного числа = {ThirdNumber(number)} ");
}