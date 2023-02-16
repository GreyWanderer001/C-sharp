using System;

class Program {
  public static void Main (string[] args) {

    string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST`S giant paw slashes it";

    Console.Write($"{script.Substring(0, script.IndexOf('n')+1).ToUpper()} + {script.Substring(script.IndexOf('a')+1).ToLower()}");
    
  }
}
