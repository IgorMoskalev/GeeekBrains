


// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.




// string OutPutNumber(int Number)
// {
//     if (Number == 1)
//         return 1.ToString();
//     return OutPutNumber(Number - 1) + ", " + Number.ToString();
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write(OutPutNumber(number));


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.Clear();

// string OutPutNumber(int Number1, int Number2)
// {
//     if (Number1 == Number2)
//         return Number1.ToString();
//     return OutPutNumber(Number1, Number2 - 1) + ", " + Number2.ToString();
// }

// Console.Write("Введите 2 числа : ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.Write(OutPutNumber(numbers[0], numbers[1]));



// int SummDigital(int number)
// {
//     if (number == 0)
//     {
//         return number;
//     }
//     return number % 10 + SummDigital(number / 10 );
// }

// Console.Clear();
// Console.Write("Введите число ");
// int nubmber = int.Parse(Console.ReadLine());
// Console.WriteLine(SummDigital(nubmber));


// Возводим в степень 


// int Pow(int a, int b) 
// {
//     if(b == 0) return 1;
//     return a*Pow(a, b - 1);   
// }

// // A^B = A * A^(B-1)

// Console.Clear();
// Console.Write("Введите число А: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine(Pow(a,b));