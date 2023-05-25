# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
# Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной.
# Выведите минимальное количество монет, которые нужно перевернуть


n = int(input("Введите кол-во монеток: "))
countSideOne = 0
countSideZero = 0
sideCoin = 0
for i in range(n):
    sideCoin = int(input("Введите сторону монеты, где 1 - это орел, 0 - решка "))
    if sideCoin == 1:
        countSideOne = countSideOne + 1
    elif sideCoin == 0:
        countSideZero = countSideZero + 1
    else: print("Вы ввели не то число!")
if countSideOne == countSideZero:
    print(f"Переваричивай любые, кол-во одинаквое {countSideOne}")
elif countSideOne < countSideZero:
    print(f"Нужно переворачивать Орлы, кол-во переворотов {countSideOne}")
else: print(f"Нужно переворачивать Решки, кол-во переворот {countSideZero}")