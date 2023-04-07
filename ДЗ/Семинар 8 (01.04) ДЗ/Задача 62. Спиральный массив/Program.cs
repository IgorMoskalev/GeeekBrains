// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив

void SpiralMatrix(int[,] matrix, int offset)
{
    for (int i = offset + 1; i < matrix.GetLength(1) - offset; i++)
    {
        matrix[offset, i] = matrix[offset, i - 1] + 1;
    }
    for (int i = offset + 1; i < matrix.GetLength(0) - offset; i++)
    {
        matrix[i, matrix.GetLength(1) - offset - 1] = matrix[i - 1, matrix.GetLength(1) - offset - 1] + 1;
    }
    for (int i = matrix.GetLength(1) - offset - 2; i >= offset; i--)
    {
        matrix[matrix.GetLength(0) - offset - 1, i] = matrix[matrix.GetLength(0) - offset - 1, i + 1] + 1;
    }
    for (int i = matrix.GetLength(0) - offset - 2; i > offset; i--)
    {
        matrix[i, offset] = matrix[i + 1, offset] + 1;
    }

    if (matrix[offset + 1, offset + 1] == 0)
    {
        matrix[offset + 1, offset + 1] = matrix[offset + 1, offset] + 1;
        SpiralMatrix(matrix, offset + 1);
    }
}

int[,] CreatMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[0]];
    matrix[0, 0] = 1;
    SpiralMatrix(matrix, 0);
return matrix;
}

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

Console.Clear();
int[,] matrix = CreatMatrix();
PrintArray(matrix);
