def busqueda_lineal(v, x):
    for i, val in enumerate(v):
        if val == x:
            return i
    return -1

def main():
    n = int(input("Ingrese N (tamaño del vector): "))
    v = [int(input(f"v[{i}] = ")) for i in range(n)]

    if n == 0:
        print("Vector vacío.")
        return

    maximo, idx = v[0], 0
    for i in range(1, n):
        if v[i] > maximo:
            maximo, idx = v[i], i

    print(f"\nMáximo = {maximo} en la posición {idx}")

    x = int(input("\nIngrese valor a buscar x: "))
    pos = busqueda_lineal(v, x)
    print(f"Encontrado en posición {pos}" if pos >= 0 else "No encontrado (retorna -1)")

if __name__ == "__main__":
    main()
