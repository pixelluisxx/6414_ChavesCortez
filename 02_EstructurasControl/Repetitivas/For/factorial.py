n = int(input("Ingresa un número: "))
f = 1
for i in range(2, n+1):
    f *= i
print("El factorial es:", f)
