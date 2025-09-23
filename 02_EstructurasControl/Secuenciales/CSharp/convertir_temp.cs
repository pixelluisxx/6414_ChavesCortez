using System;
class Program {
  static void Main() {
    string modo = Console.ReadLine().Trim().ToUpper(); // C2F o F2C
    double t = double.Parse(Console.ReadLine());
    if (modo == "C2F") Console.WriteLine((t * 9.0/5.0) + 32.0);
    else if (modo == "F2C") Console.WriteLine((t - 32.0) * 5.0/9.0);
    else Console.WriteLine("Modo inválido");
  }
}
