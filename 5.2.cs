using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Ievadiet tekstu: ");
    string text = Console.ReadLine();
    string[] words = text.Split(' ');
    foreach (string word in words) {
      if (word.StartsWith("a") || word.StartsWith("A")) {
        Console.WriteLine(word);
      }
    }
  }
}
