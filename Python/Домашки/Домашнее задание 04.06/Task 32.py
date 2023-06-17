# Задача 32: Определить индексы элементов массива (списка), 
# значения которых принадлежат заданному диапазону 
# (т.е. не меньше заданного минимума и не больше заданного максимума)

def min_max_index(list_1, min, max):
    index_list = []
    for i in range(0, len(list_1)):
        if list_1[i] >= min and list_1[i] <= max:
            index_list.append(i)
    return(index_list)

list_1 = [-5, 9, 0, 3, -1, -2, 1, 4, -2, 10, 2, 0, -9, 8, 10, -9, 0, -5, -5, 7]
min = 5
max = 15
print(min_max_index(list_1, min, max))