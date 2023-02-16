using System;

class Program {
  public static void Main (string[] args) {
    
    Console.Write("Ievadiet virkni: ");
    string virkne = Console.ReadLine();
    int a = 0;

    foreach (var i in virkne) {
      if (Char.IsPunctuation(i)) {
        a++;
      }
    }
    Console.WriteLine($"Teksta ir {a} pieturzīmes");


    char[] ch = new char[virkne.Length]; 

    for (int i = 0; i < virkne.Length; i++) { 
        ch[i] = virkne[i]; 
    } 

    int b = 0;
    foreach (var i in ch) {
      if (Char.IsPunctuation(i)) {
        b++;
      }
    }
    Console.WriteLine($"Teksta ir {b} pieturzīmes");
    }
}
