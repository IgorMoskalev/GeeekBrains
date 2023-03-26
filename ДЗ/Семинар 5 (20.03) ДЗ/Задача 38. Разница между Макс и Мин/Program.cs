// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void InputArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = Math.Round(new Random().NextDouble() * (100 - 1) + 1); 
}

void DifferenceBetweenMaxAndMinArray (double[] array)
{
    double max = array[0], min = array[0], diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
                min = array[i];
    }
    Console.Write($"Разниза между максимальным: {max} и минимальным: {min}, равна: {diff = max - min}");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
DifferenceBetweenMaxAndMinArray(array);