// if(x > 0 && x < 5)
// {
//     if (x  == 1 )
//     Console.WriteLine("X - от нуля до бесконечности. Y - от нуля до бесконечности");
//     else if (x == 2)
//      Console.WriteLine("X - от нуля до минус бесконечности. Y - от нуля до бесконечности");
//     else if (x == 3)
//         Console.WriteLine("X - от нуля до минус бесконечности. Y - от нуля до  минус бесконечности");
//     else
//      Console.WriteLine("X - от нуля до бесконечности. Y - от нуля до  минус бесконечности");
// }
// else
// Console.WriteLine("Не верная четверть!");



// 1. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



// Console.Clear();
// Console.Write("Введите кординаты точки A по оси X=  ");
// double A1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординаты точки A по оси Y=  ");
// double A2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординаты точки B по оси X=  ");
// double B1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите кординаты точки B по оси Y=  ");
// double B2 = Convert.ToDouble(Console.ReadLine());

// double A = A1 - B1;
// double B = A2 - B2;
// A = Math.Pow(A, 2);
// B = Math.Pow(B, 2);
// double distance = Math.Sqrt(A + B);
// Console.WriteLine(distance);


// Console.Clear();
// Console.Write("n =  ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++) 
//     Console.Write($"{Math.Pow(i, 2)} ");