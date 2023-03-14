// Напишите программу, которая
// на вход принимает число (N)
// и выдает таблицу квадратов чисел
// от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);

void TableSquare (int number)
{
    int count = 1;
    while (count <= number)
    {
        int squad = count * count;
        Console.WriteLine($"{count} -> {squad}");
        count++;
    }
}
