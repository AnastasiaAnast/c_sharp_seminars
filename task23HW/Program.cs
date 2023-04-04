// Напишите программу, которая 
// принимает на вход число (N) и 
// выдает таблицу кубов чисел от 1 до N

void CubeTable(int number)
{
    int count = 1;
while(count <= number)
    {
    int cube = count * count * count;
    Console.WriteLine($"{count,4} -> {cube,8}");
    count++;
    }
}


Console.WriteLine("Введите натуральное число, чтобы увидеть таблицу кубов чисел от 1 до указанного числа: ");
int num = Convert.ToInt32(Console.ReadLine());


CubeTable(num);