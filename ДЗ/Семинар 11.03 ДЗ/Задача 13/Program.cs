// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a > 99) 
{
    string str = a.ToString(); 
    Console.WriteLine(str[2]);
}
else
Console.WriteLine("Третьей цифры нет");