// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000 )
{
    int [] nums = new int[5];
    for (int i = 4; i >= 0; i--)
    {    
        nums[i] = number % 10;
        number = number / 10;
    }
    // Console.WriteLine("[{0}]", string.Join(", ", nums));
    if (nums[0] == nums[4] && nums[1] == nums[3])
    {
        Console.WriteLine("Введеное число палиндром!");
    }
    else
    Console.WriteLine("Введеное число НЕ ПАЛИНДРОМ!");
}
else
  Console.WriteLine("Вы ввели нe пятизначное число! ");
