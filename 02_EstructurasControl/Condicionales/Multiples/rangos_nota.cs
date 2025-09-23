using System;
class Program {
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    string g = n >= 17 ? "A" :
               n >= 14 ? "B" :
               n >= 11 ? "C" :
               n >= 8  ? "D" : "F";
    Console.WriteLine(g);
  }
}
