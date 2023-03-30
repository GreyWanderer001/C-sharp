using System;

namespace wallet {
  public class Wallet { // klasses izveidošana
    private static int count;
    public string name;
    public float sum;
    public float add;
    public float remove;
  
    public Wallet(string nameName, float sumName, float addName, float removeName) {
      count++;
      name = nameName;
      sum = sumName;
      add = addName;
      remove = removeName;
    }

    public void ChangeSum() { // bilances rediģešana
      this.sum = this.sum + this.add;
      this.sum = this.sum - this.remove;
    }
  
    public void Print() { // maksas izvadīšana
      Console.Write("\n");
      Console.Write($"Wallet user: {this.name}\n");
      Console.Write($"Balance: {this.sum}€\n");
      Console.Write($"To your balance has been added: {this.add}€\n");
      Console.Write($"From your balance has been removed: {this.remove}€\n");
      Console.Write("\n");
    }

    public static int WalletsCount() {
      return count;
    }
  }
}
