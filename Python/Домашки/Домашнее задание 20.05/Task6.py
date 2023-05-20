# Вы пользуетесь общественным транспортом? Вероятно, вы
# расплачивались за проезд и получали билет с номером. Счастливым
# билетом называют такой билет с шестизначным номером, где сумма
# первых трех цифр равна сумме последних трех. Т.е. билет с номером
# 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать
# программу, которая проверяет счастливость билета.

number = int(input("введите шестизначное число: "))
if number > 99999 and number < 1000000:
    firstThreeNumbers = number // 1000
    nextThreeNumbers = number % 1000
    firstThreeNumbers = firstThreeNumbers // 100 + firstThreeNumbers // 10 % 10 + firstThreeNumbers % 10
    nextThreeNumbers = nextThreeNumbers // 100 + nextThreeNumbers // 10 % 10 + nextThreeNumbers % 10
    if firstThreeNumbers == nextThreeNumbers:
        print("Yes")
    else: print("No")
else: print("Вы ввели не 6-ти значное число!")