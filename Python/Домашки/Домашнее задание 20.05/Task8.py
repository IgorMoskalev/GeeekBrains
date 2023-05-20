n = int(input("Введите N: "))
m = int(input("Введите M: "))
k = int(input("Введите K: "))
if k % n == 0 or k % m == 0:
    print("Yes")
else: print("No")