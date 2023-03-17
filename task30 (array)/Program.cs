// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array =  new int[8]; // это представление массива с 8-ю элементами
// int[] arr = {1, 2, 3}; // это представление массива с конкретными значениями элементов
// array[3]// получить доступ к элементу массива - по индексу
// array[3] = 34 // присвоить новое значение элементу под индексом 3
// for (int i = 0; i < array.Length; i++)// цикл for самый удобный для работы с массивами, тк счетчик начинается с 0
// {
//     array[i] = 
// }

// создать метод, который будет заполнять массив
// отдельный метод - print array - Console.Write(array[i] + "");

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.Write(array[i] + " ");
    }
}