# Convierte entre Celsius y Fahrenheit
modo = input("C2F o F2C: ").strip().upper()
t = float(input("Temperatura: "))
if modo == "C2F":
    print((t * 9/5) + 32)
elif modo == "F2C":
    print((t - 32) * 5/9)
else:
    print("Modo inválido")
