// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[, ] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[, ] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}


void MinSumStringInArray(int[, ] matrix)
{
    int min = 0;
    int minString = 1;
    int firstString = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            firstString = firstString + matrix[0, j];
            min = firstString;
        }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumString = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumString = sumString + matrix[i, j];
            
        }
        if (sumString < min)
        {
            min = sumString;
            minString = i + 1;
        }
        
    }
    Console.WriteLine($"Строка {minString} это строка c минимальной суммой элементов");

}


Console.Clear();
int[, ] matrix = InputMatrix();
MinSumStringInArray(matrix);