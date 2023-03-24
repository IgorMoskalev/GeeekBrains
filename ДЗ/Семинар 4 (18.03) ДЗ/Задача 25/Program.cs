// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double degree (double numb1, double numb2)
{
    numb1 = Math.Pow(numb1, numb2);
    return numb1;
}

Console.Clear();
Console.Write("Введите первое число = ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень в которое нужно возвести число = ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат = {degree(numb1, numb2)}");
