// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[, ] InputMatrix()
// {
//     Console.Write("Введите размер матрицы: ");
//     int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     int[, ] matrix = new int[size[0], size[1]];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 50);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// void ChangeArray(int [, ] matrix)
// {
//     int temp; 
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         temp = matrix[0,i];
//         matrix[0,i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }

// }

// Console.Clear();
// int[, ] matrix = InputMatrix();
// ChangeArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// перестановка строк и столбцов в многомерном массиве 
// int[] SingleLineInput(int reqSizeArray)
// {
//     int[] array;
//     System.Console.WriteLine("Enter single line array with a \"space\"");
//     do
//     {
//         array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//         if (array.Length != reqSizeArray)
//         {
//             System.Console.WriteLine("Wrong enter, please try again");
//         }
//     } while (array.Length != reqSizeArray);
//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             System.Console.Write($"{matrix[rows, columns]} \t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FillMatrix(int[,] matrix, int min, int max)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             matrix[rows, columns] = new Random().Next(min, max + 1);
//         }
//     }
// }

// int[,] CreateUserMatrix()
// {
//     System.Console.WriteLine("Enter size matrix");
//     int[] size = SingleLineInput(2);
//     return new int[size[0], size[1]];
// }

// bool CheckSizeMatrix(int[,] matrix)
// {
//     return matrix.GetLength(0) == matrix.GetLength(1);
// }

// int[,] ReleaseMatrix(int[,] matrix)
// {
//     int[,] transpMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             transpMatrix[columns, rows] = matrix[rows, columns];
//         }
//     }
//     return transpMatrix;
// }

// System.Console.Clear();
// int[,] matrix = CreateUserMatrix();
// FillMatrix(matrix, 1, 10);
// PrintMatrix(matrix);
// if (CheckSizeMatrix(matrix))
// {
//     PrintMatrix(ReleaseMatrix(matrix));
// }
// else
// {
//     System.Console.WriteLine("Кол-во строк и кол-во столбцов не совпадает");
// }



// int[, ] InputMatrix()
// {
//     Console.Write("Введите размер матрицы: ");
//     int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     int[, ] matrix = new int[size[0], size[1]];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 50);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// int[] Conver2dTo1D(int[, ] matrix)
// {
//     int k = 0;
//     int[] array = new int [matrix.GetLength(0) * matrix.GetLength(1) ];
//     for( int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for( int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[k++] = matrix[i,j];
            
//         }
//     }
//     return array;
// }

// void PrintFr(int [] array)
// {
//     int count = 1;
//     int oldValu = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (oldValu == array[i])
//         count++;
//         else
//         {
//              Console.WriteLine($"{oldValu} встречается в массмиве: {count}");
//              count = 1;
//              oldValu = array[i];
//         }
//     }
//     Console.WriteLine($"{oldValu} встречается в массмиве: {count}");
// }

// Console.Clear();
// int[, ] matrix = InputMatrix();
// int[] array = Conver2dTo1D(matrix);
// Array.Sort(array);
// PrintFr(array);


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец
// , на пересечении которых расположен наименьший элемент массива

//  int[, ] InputMatrix()
// {
//     Console.Write("Введите размер матрицы: ");
//     int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     int[, ] matrix = new int[size[0], size[1]];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 50);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }


// int[] GetMinimalIndex(int[,] matrix)
// {
//     int min = matrix[0, 0];
//     int[] result = new int[2];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < min)
//             {
//                 min = matrix[i, j];
//                 result[0] = i;
//                 result[1] = j;
//             }
//         }
//     }
//     return result;
// }

// int[,] DeletePosition(int[,] matrix, int[] array)
// {
//     int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     int row = 0;
//     int column = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i == array[0])
//             continue;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == array[1])
//                 continue;
//             resultMatrix[row, column] = matrix[i, j];
//             column++;
//         }
//         row++;
//         column = 0;
//     }
//     return resultMatrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] SizeOfMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] Matrix = new int[SizeOfMatrix[0], SizeOfMatrix[1]];

// InputMatrix(Matrix);
// int[] Indexes = GetMinimalIndex(Matrix);
// int[,] NewMatrix = DeletePosition(Matrix, Indexes);
// Console.WriteLine();
// PrintMatrix(NewMatrix);

