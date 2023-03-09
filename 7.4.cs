using System;

class Student {
  public string Vards;
  public int Kurss;
  public bool Stipendija;

  
  public Student(string VardsName) {
    Vards = VardsName;
    Kurss = 1;
    Stipendija = false;
  }
  
  public Student(string VardsName, int KurssName) {
    Vards = VardsName;
    Kurss = KurssName;
    Stipendija = false;
  }
  
  public Student(string VardsName, int KurssName, bool StipendijaName) {
    Vards = VardsName;
    Kurss = KurssName;
    Stipendija = StipendijaName;
  }

  public void Print() {
    Console.Write($"{this.Vards} ");
    Console.Write($"{this.Kurss} ");
    Console.Write(this.Stipendija);
    Console.Write("\n");
  }
}

class Program {
  public static void Main (string[] args) {
    Student student1 = new Student("Andrejs");
    Student student2 = new Student("Daniels", 3);
    Student student3 = new Student("Deniss", 2, true);

    student1.Print();
    student2.Print();
    student3.Print();
  }
}
