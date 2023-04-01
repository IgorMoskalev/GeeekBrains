// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 50);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void PrintPozition(int [, ] matrix)
{
    Console.Write("Введите позицию элемента через запятую: ");
    int[] pozition = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
    if (matrix.GetLength(0) >= pozition[0]
        && matrix.GetLength(1) >= pozition[1])
    {
        Console.Write($"Под введенной позицией находится число: {matrix[pozition[0], pozition[1]]}");

    }
    else Console.Write("Такой позиции нет");
}

Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int [size [0], size [1]];
InputMatrix (matrix);
PrintPozition (matrix);