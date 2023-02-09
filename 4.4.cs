using System;

class Program {
  public static void Main (string[] args) {
    
    Console.Write("Ievadiet A skaitli: ");
    int mainigaisA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ievadiet B skaitli: ");
    int mainigaisB = Convert.ToInt32(Console.ReadLine());

    if (mainigaisA < mainigaisB) {
      for (int i = mainigaisA; i <= mainigaisB; i++) {
        if (i % 10 == 3) {
          Console.WriteLine(i);
        }
      }
    }

    else if (mainigaisA > mainigaisB) {
      for (int i = mainigaisA; i >= mainigaisB; i--) {
        if (i % 10 == 3) {
          Console.WriteLine(i);
        }
      }
    } 
  }
}
