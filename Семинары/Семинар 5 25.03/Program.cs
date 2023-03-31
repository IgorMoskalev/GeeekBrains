// // второй максиум
// Console.Clear();

// int[] array = Console.ReadLine().Split(" 5 ").Select(x => int.Parse(x)).ToArray();
// // "5 4 3 2"
// // "5", "4", "3", "2"
// // 5, 4, 3, 2
// // [5, 4, 3, 2]
// Console.WriteLine($"[{string.Join(", ", array)}]");


// foreach (int elem in array)
//     Console.WriteLine(elem * 100);


// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// void InputArray(int[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 		array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");


// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// AB < AC + BC
// AC < AB + BC
// BC < AC + AB
// Источник: https://colibrus.ru/suschestvuyuschie-treugolniki


// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.


// void ReleaseArray(int[] array)
// {
//     if (array[0] < array[1] + array[2] 
//         && array[1] < array[0] + array[2] 
//         && array[2] < array[0] + array[1])
//         Console.Write("Yes");
//     else
//         Console.Write("No");
// }

// Console.Clear();
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// ReleaseArray(array);

// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string res = String.Empty;
// while(n > 0)
// {
//     res = Convert.ToString(n % 2) + res;
//     n /= 2;
// }
// Console.WriteLine(res);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// 0 1 1 2 3 5 8 13 

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1, x;

// for (int i = 0; i < n; i ++)
// {
//     Console.Write($"{a0} ");
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


 void InputArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-9, 10); // [-9, 9]
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] a = new int [size];
int [] b = new int [a.Length];

InputArray(a);

for (int i = 0; i < a.Length; i++)
{
    b[i] = a[i];
}
Console.Clear();
Console.WriteLine($"[{string.Join(", ", a)}]");
b[3] = 10;
Console.WriteLine($"[{string.Join(", ", b)}]");