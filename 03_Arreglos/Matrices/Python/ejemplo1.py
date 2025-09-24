def leer_matriz(f, c, nombre):
    print(f"\nIngrese elementos de {nombre}:")
    M = []
    for i in range(f):
        fila = []
        for j in range(c):
            fila.append(int(input(f"{nombre}[{i},{j}] = ")))
        M.append(fila)
    return M

def suma_matrices(A, B):
    f, c = len(A), len(A[0])
    return [[A[i][j] + B[i][j] for j in range(c)] for i in range(f)]

def imprimir_matriz(M, titulo):
    print(f"\n{titulo}:")
    for fila in M:
        print("".join(str(x).rjust(6) for x in fila))

def main():
    f = int(input("Filas: "))
    c = int(input("Columnas: "))

    A = leer_matriz(f, c, "A")
    B = leer_matriz(f, c, "B")
    C = suma_matrices(A, B)

    imprimir_matriz(C, "Matriz C = A + B")

if __name__ == "__main__":
    main()
