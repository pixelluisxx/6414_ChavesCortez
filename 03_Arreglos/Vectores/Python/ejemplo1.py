def main():
    n = int(input("Ingrese N (tamaño del vector): "))
    v = [int(input(f"v[{i}] = ")) for i in range(n)]

    promedio = sum(v)/n if n > 0 else 0
    mayores = sum(1 for x in v if x > promedio)

    print(f"\nPromedio = {promedio:.2f}")
    print(f"Cantidad mayores al promedio = {mayores}")

if __name__ == "__main__":
    main()
