//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int NumberC = Convert.ToInt32(Console.ReadLine());
int max = NumberA;
if(NumberA > max) max = NumberA;
if(NumberB > max) max = NumberB;
if(NumberC > max) max = NumberC;
Console.WriteLine($"Максимальное значени: {max}");