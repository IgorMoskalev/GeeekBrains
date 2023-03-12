// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Введите число от 1 до 7 которое обозначает день недели: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());
if( WeekDay > 0 && WeekDay < 8) 
{
    if(WeekDay == 6 || WeekDay == 7)
    {
       Console.WriteLine("Это выходной день! "); 
    }
    else 
    Console.WriteLine("Это рабочий день иди работать! ");
}
else
Console.WriteLine($"Число {WeekDay} не является днем недели! ");