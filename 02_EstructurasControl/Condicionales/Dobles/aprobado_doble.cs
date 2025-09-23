using System;
class Program {
  static void Main() {
    double nota = double.Parse(Console.ReadLine());
    Console.WriteLine(nota >= 11 ? "Aprobado" : "Desaprobado");
  }
}
