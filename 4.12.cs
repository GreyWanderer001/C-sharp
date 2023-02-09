using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Ievadiet n skaitli: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Reizinajuma tabula no 1 lidz {n}: ");
    Console.WriteLine("----------------------------------");

    for (int i = 1; i < 11; i++) {
      for (int y = 1; y < n+1; y++) {
        Console.Write($"{y} * {i} = {i*y}, ");
      }
      Console.WriteLine();
    }
  }
}
