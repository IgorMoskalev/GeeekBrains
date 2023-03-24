// Задача 29: Напишите программу, которая будет создавать массив из 8 символов и заполнять значениями от пользователя

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void InputArray(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;      
    }        
}


Console.Clear();
Console.Write("Введите колличество символов которые вы хотите внести в массив: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
