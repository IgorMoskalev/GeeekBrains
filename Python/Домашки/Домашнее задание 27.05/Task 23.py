# Задача №23. Общее обсуждение
# Дан массив, состоящий из целых чисел. Напишите
# программу, которая подсчитает количество
# элементов массива, больших предыдущего (элемента
# с предыдущим номером)
# Input: [0, -1, 5, 2, 3]
# Output: 2 (-1 < 5, 2 < 3)
# Примечание: Пользователь может вводить значения
# списка или список задан изначально.


list = [0, -1, 5, 2, 3]
indexFirst = list[0]
count = 0
for i in range(len(list)):
    if list[i]>indexFirst:
        count += 1
    indexFirst = list[i]
print(count)


