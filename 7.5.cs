using System;

class Prece {
  internal string Nosaukums;
  internal float Cena;
  internal string Apraksts;
  
  public Prece(string NosaukumsName, float CenasName, string AprakstsName) {
    Nosaukums = NosaukumsName;
    Cena = CenasName;
    Apraksts = AprakstsName;
  }

  public void Print() {
    Console.WriteLine($"Preces nosaukums: {this.Nosaukums}");
    Console.WriteLine($"Preces Cena: {this.Cena}");
    Console.WriteLine($"Preces apraksts: {this.Apraksts}");
  }
}

class Program {
  public static void Main (string[] args) {
    Prece prece1 = new Prece("Banans", 14.05f, "Loti garsigs");

    prece1.Print();
  }
}
