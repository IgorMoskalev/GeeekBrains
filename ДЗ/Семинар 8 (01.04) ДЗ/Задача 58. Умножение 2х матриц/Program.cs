// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[, ] InputMatrix()  // Функция заполнения матрицы
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[, ] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}


int[, ] CheckingForMatrixMultiplication(int [, ] matrixOne, int [, ] matrixTwo)  // Функция проверки и вызова функции перемножения матриц
{   
    int[, ] matrix = new int[matrixOne.GetLength(1),matrixTwo.GetLength(0)];
    if ( matrixOne.GetLength(1) != matrixTwo.GetLength(0))
    {
        Console.WriteLine("Данные матрицы перемножать нельзя!");
    }
    else matrix = MultiplicationMatrix(matrixOne, matrixTwo); // сделать вызов функции по перемножению матрицы
    return matrix;
        


}

int[, ] MultiplicationMatrix(int [, ] matrixOne, int [, ] matrixTwo)
{
    int[, ] matrixFinish = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    int countNumbers = matrixOne.GetLength(0) * matrixTwo.GetLength(1);
    for ( int i = 0; i < matrixOne.GetLength(0); i++)
       {
            for(int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                for (int k = 0; k < matrixOne.GetLength(1); k++)
                {
                    matrixFinish[i, j]  += matrixOne[i, k] * matrixTwo[k, j];
                }
            }
       }
    return matrixFinish;
}


Console.Clear();
int [, ] matrixOne = InputMatrix();
int [, ] matrixTwo = InputMatrix();
int [, ] matrix = CheckingForMatrixMultiplication(matrixOne, matrixTwo);
Console.WriteLine("Итоговая матрица С ");
PrintArray(matrix);
