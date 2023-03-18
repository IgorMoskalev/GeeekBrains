// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите кординату x1= ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y1= ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату с1= ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату x2= ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y2= ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату c2= ");
double c2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2)));

