# Задача 12: Петя и Катя – брат и сестра.
# Петя – студент, а Катя – школьница. Петя помогает Кате по математике. 
# Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает две подсказки.
#   Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.

numberMultiplication = int(input("Введите произведение "))
numberSumm = int(input("Введите сумму "))
status = 0
for i in range(1001):
    if status != 0:
        break
    for j in range(1001):
        if i+j == numberSumm and i*j == numberMultiplication:
            print(i, j)
            status = 1
            break