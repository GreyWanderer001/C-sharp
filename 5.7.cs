using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Ievadiet paroli: ");
    string password = Console.ReadLine();
    int passwordLength = password.Length;
    bool passwordCheck = true;

    Console.WriteLine($"Password is {password}");
    Console.WriteLine($"Its length is {passwordLength}");
    
    if (password.Contains("!")) {
        passwordCheck = true;
    } else {
      passwordCheck = false;
    }


    Console.WriteLine(passwordCheck);
    
  }
}
