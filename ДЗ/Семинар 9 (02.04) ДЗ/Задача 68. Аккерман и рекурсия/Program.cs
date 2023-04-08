// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int Akkerman (int numberOne, int numberTwo)
{
    if (numberOne == 0)
    {
        return numberTwo + 1;
    }
    else if (numberTwo == 0)
    {
        return Akkerman(numberOne - 1, 1);
    }
    else return Akkerman(numberOne - 1, Akkerman(numberOne, numberTwo - 1));  
}



Console.Clear();
Console.Write("Введите 2 числа : ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(Akkerman(numbers[0], numbers[1])); 