# Задача 18: Требуется найти в массиве A[1..N] самый близкий по
# величине элемент к заданному числу X. Пользователь в первой строке
# вводит натуральное число N – количество элементов в массиве. В
# последующих строках записаны N целых чисел Ai
# . Последняя строка
# содержит число X

n = int(input("Введите длину массива "))
array = [i for i in range(1, n+1)]
x = int(input("Введите X "))
firstDelta = abs(array[0] - x)
min = firstDelta
for i in array:
    delta = abs(i - x)
    if delta < firstDelta:
        firstDelta = delta
        min = i
print(min)

