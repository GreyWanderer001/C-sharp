using System;

class Program {
  public static void Main (string[] args) {

    int s = 0;
    int mainigais = 99;

    while (mainigais <= 100) {
      Console.Write("Ievadiet skaitli: ");
      mainigais = Convert.ToInt32(Console.ReadLine());
    }
      
    while (mainigais > 0) {
 
      s = s + mainigais % 10;
      mainigais = mainigais /10 ;
    }

    Console.WriteLine(s);
    
  }
}
