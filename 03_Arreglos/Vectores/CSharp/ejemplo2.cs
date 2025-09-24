using System;
class Programa {
    static void Main() {
        Console.Write("Ingrese N (tamaño del vector): ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        int[] v = new int[n];

        for (int i = 0; i < n; i++) {
            Console.Write($"v[{i}] = ");
            v[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        if (n == 0) { Console.WriteLine("Vector vacío."); return; }

        int max = v[0], idx = 0;
        for (int i = 1; i < n; i++)
            if (v[i] > max) { max = v[i]; idx = i; }

        Console.WriteLine($"\nMáximo = {max} en la posición {idx}");

        Console.Write("\nIngrese valor a buscar x: ");
        int x = int.Parse(Console.ReadLine() ?? "0");
        int pos = -1;
        for (int i = 0; i < n; i++)
            if (v[i] == x) { pos = i; break; }

        Console.WriteLine(pos >= 0 ? $"Encontrado en posición {pos}" : "No encontrado (retorna -1)");
    }
}
