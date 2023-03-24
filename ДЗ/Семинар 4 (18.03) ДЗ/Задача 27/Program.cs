// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int sum_of_numbers (string number)
{
    int size = Convert.ToInt32(number.Length);
    int number1 = Convert.ToInt32(number);
    int sum = 0;
    
    for (int i = 0; i < size; i++)
    {
        sum = sum + number1 % 10;
        number1 = number1 / 10;
    }
    
    return sum;

}

Console.Clear();
Console.Write("Введите число = ");
string number = Console.ReadLine();
Console.WriteLine($"Результат = {sum_of_numbers(number)}");