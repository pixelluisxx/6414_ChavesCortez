def transpuesta(M):
    return [list(fila) for fila in zip(*M)]

def suma_diagonal(M):
    return sum(M[i][i] for i in range(len(M)))

def main():
    n = int(input("n (para matriz n x n): "))
    M = []
    print("\nIngrese elementos de M:")
    for i in range(n):
        fila = []
        for j in range(n):
            fila.append(int(input(f"M[{i},{j}] = ")))
        M.append(fila)

    T = transpuesta(M)
    diag = suma_diagonal(M)

    print("\nTranspuesta T:")
    for fila in T:
        print("".join(str(x).rjust(6) for x in fila))

    print(f"\nSuma de la diagonal principal = {diag}")

if __name__ == "__main__":
    main()
