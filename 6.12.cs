using System;

class Program {
  public static void Main (string[] args) {
    string[] spaceRocks = {"meteroid", "meteor", "meteorite"};

    bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

    if (makesContact) {
      Console.WriteLine("At least one space rock has reached the Earth's surface!");
    }
  }
  
}
