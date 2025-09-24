using System;
class Programa {
    static void Main() {
        Console.Write("Filas: ");
        int f = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Columnas: ");
        int c = int.Parse(Console.ReadLine() ?? "0");

        int[,] A = new int[f, c];
        int[,] B = new int[f, c];
        int[,] C = new int[f, c];

        Console.WriteLine("\nIngrese elementos de A:");
        for (int i = 0; i < f; i++)
            for (int j = 0; j < c; j++) {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }

        Console.WriteLine("\nIngrese elementos de B:");
        for (int i = 0; i < f; i++)
            for (int j = 0; j < c; j++) {
                Console.Write($"B[{i},{j}] = ");
                B[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }

        for (int i = 0; i < f; i++)
            for (int j = 0; j < c; j++)
                C[i, j] = A[i, j] + B[i, j];

        Console.WriteLine("\nMatriz C = A + B:");
        for (int i = 0; i < f; i++) {
            for (int j = 0; j < c; j++)
                Console.Write(C[i, j].ToString().PadLeft(6));
            Console.WriteLine();
        }
    }
}
