// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void NumberOfPositiveInArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write($"Колличество положительных чисел = {count}");
}

Console.Clear();
Console.Write("Введите числа через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
NumberOfPositiveInArray(array);