// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
Console.WriteLine("Введите число 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());

if(a % b == 0  || b % a == 0)
    Console.WriteLine("Да");
else
Console.WriteLine($"Нет");


