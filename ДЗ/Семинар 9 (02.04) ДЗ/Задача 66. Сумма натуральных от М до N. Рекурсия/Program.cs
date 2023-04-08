// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int OutPutNumber(int Number1, int Number2)
{
    int sum = 0;
    if (Number1 == Number2)
        return Number1;
    sum = OutPutNumber(Number1, Number2 - 1) + Number2;
    return sum;
}

Console.Clear();
Console.Write("Введите 2 числа : ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(OutPutNumber(numbers[0], numbers[1]));
