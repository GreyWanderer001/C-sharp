using System;

using Wallet = wallet.Wallet;

class Program {
  public static void Main (string[] args) {

    string ans;
    Wallet wallet1; // klasses izveidošana
    
    Console.Write("Create wallet?(y/n): ");
    ans = Console.ReadLine();
    
    if (ans == "y") { //parbaude, vai izveidot maksu
      string name;
      float sum = 0;
      float add = 0;
      float remove = 0;
      Console.Write("Enter wallet users name: "); //prasa lietotajam ievadi maksas ipašnieku
      name = Console.ReadLine();

      Console.Write("Enter wallet balance: ");
      while (sum <= 0) {
        sum = float.Parse(Console.ReadLine()); // bilances piešķiršana caur konvertešanu

        if (sum <= 0) {
          Console.Write("Enter POSITIVE wallet balance: ");
        }
        
      } 

      Console.Write("Do you want to top up the balance?(y/n): "); //vai lietotajs grib piešķirt naudu bilancei
      ans = Console.ReadLine();
      if (ans == "y") {
        Console.Write("How much money to allocate: ");
        add = float.Parse(Console.ReadLine());
      } else if (ans == "n") {
        Console.Write("Do you want to remove money from your balance?(y/n): ");
        ans = Console.ReadLine();
        if (ans == "y") {
          Console.Write("How do you want to remove from the balance: ");
          remove = float.Parse(Console.ReadLine());
        }
      } 
     
      wallet1 = new Wallet(name, sum, add, remove); // klasses rediģēšana
      wallet1.ChangeSum();
      wallet1.Print();
    } else if (ans == "n") {
      Console.Write("Okey, bye");
    } else {
      Console.Write("Incorrect input!");
    }

    Wallet wallet2;
    
    Console.Write("Create second wallet?(y/n): ");
    ans = Console.ReadLine();
    
    if (ans == "y") {
      string name;
      float sum = 0;
      float add = 0;
      float remove = 0;
      Console.Write("Enter wallet users name: ");
      name = Console.ReadLine();

      Console.Write("Enter wallet balance: ");
      while (sum <= 0) {
        sum = float.Parse(Console.ReadLine());

        if (sum <= 0) {
          Console.Write("Enter POSITIVE wallet balance: ");
        }
        
      } 

      Console.Write("Do you want to top up the balance?(y/n): ");
      ans = Console.ReadLine();
      if (ans == "y") {
        Console.Write("How much money to allocate: ");
        add = float.Parse(Console.ReadLine());
      } else if (ans == "n") {
        Console.Write("Do you want to remove money from your balance?(y/n): ");
        ans = Console.ReadLine();
        if (ans == "y") {
          Console.Write("How do you want to remove from the balance: ");
          remove = float.Parse(Console.ReadLine());
        }
      } 
     
      wallet2 = new Wallet(name, sum, add, remove);
      wallet2.ChangeSum();
      wallet2.Print();
    } else if (ans == "n") {
      Console.Write("Okey, bye");
    } else {
      Console.Write("Incorrect input!");
    }

    Console.Write("Wallet count: ");
    Console.WriteLine(Wallet.WalletsCount());
    
  }
}
