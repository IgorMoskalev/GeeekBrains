# Задача 2: Найдите сумму цифр трехзначного числа. 

number = int(input("Введите трехзначное число: "))
if number > 99 and number < 1000:
    print (f"{(number % 10) + (number // 10 % 10) + (number // 100)} ({(number // 100)} + {(number // 10 % 10)} + {(number % 10)})" )
    
else: print ("это не трехзначное число")

