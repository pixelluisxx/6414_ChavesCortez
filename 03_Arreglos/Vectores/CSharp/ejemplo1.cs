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

        double suma = 0;
        foreach (int x in v) suma += x;
        double promedio = n > 0 ? suma / n : 0;

        int mayores = 0;
        foreach (int x in v) if (x > promedio) mayores++;

        Console.WriteLine($"\nPromedio = {promedio:F2}");
        Console.WriteLine($"Cantidad mayores al promedio = {mayores}");
    }
}
