using System;
class Program {
  static void Main() {
    double total = 0;
    while (true) {
      Console.Write("Ingresa un número (0 para terminar): ");
      double x = double.Parse(Console.ReadLine());
      if (x == 0) break;
      total += x;
    }
    Console.WriteLine("La suma es: " + total);
  }
}
