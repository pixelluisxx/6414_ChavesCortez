using System;
class Programa {
    static void Main() {
        Console.Write("n (para matriz n x n): ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[,] M = new int[n, n];
        Console.WriteLine("\nIngrese elementos de M:");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++) {
                Console.Write($"M[{i},{j}] = ");
                M[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }

        int[,] T = new int[n, n];
        int sumaDiag = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++) {
                T[j, i] = M[i, j];
                if (i == j) sumaDiag += M[i, j];
            }

        Console.WriteLine("\nTranspuesta T:");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++)
                Console.Write(T[i, j].ToString().PadLeft(6));
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma de la diagonal principal = {sumaDiag}");
    }
}
