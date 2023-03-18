// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int f(int n)
// {
//     count = 0;
//     for (int i = 0; n > 0; i++)
//         {
//             n = n / 10;
//             count++;
//         }
//     return count;   
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(number));



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int f(int n)
// {
    
//     int res = 1;
//     for (int i = 2; i <= n; i ++)
//         res *= i;
//     return res;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(number));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 2); //[0,1]
        
}

Console.Clear();
int[] array = new int[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");