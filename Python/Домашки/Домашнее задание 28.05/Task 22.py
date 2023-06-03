# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества. 
# Затем пользователь вводит сами элементы множеств.

sizeOne = int(input("Введите кол-во элементов 1го множества "))
userArrayOne = set()
for i in range(sizeOne):
    newNumber = input("Введите число ")
    userArrayOne.add(newNumber)

sizeTwo = int(input("Введите кол-во элеменов 2го множества "))
userArrayTwo = set()
for i in range(sizeTwo):
    newNumber = input("Введите число ")
    userArrayTwo.add(newNumber)

array = userArrayOne.intersection(userArrayTwo)
arraySort = list(array)
arraySort.sort()

print(arraySort)