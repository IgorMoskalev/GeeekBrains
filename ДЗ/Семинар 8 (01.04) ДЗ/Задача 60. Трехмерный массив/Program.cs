// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,, ] InputMatrix()  // Функция заполнения матрицы
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,, ] matrix = new int[size[0], size[1], size[2]];
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                temp = new Random().Next(10, 100);
                foreach (int g in matrix)
                {
                    while (g == temp)
                    {
                        temp = new Random().Next(10, 100);
                    }
                }
                matrix[i, j, k] = temp;
                Console.WriteLine($"{matrix[i, j, k]}({i},{j},{k}) \t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,, ] matrix = InputMatrix();