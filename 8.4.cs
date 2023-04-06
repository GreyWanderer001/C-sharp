using System;

public class Student
{
    public string Uzvards { get; set; }
    public int MacibuKurss { get; set; }
    public int AtzimesGramatasNumurs { get; set; }

    public Student(string uzvards, int macibuKurss, int atzimesGramatasNumurs)
    {
        Uzvards = uzvards;
        MacibuKurss = macibuKurss;
        AtzimesGramatasNumurs = atzimesGramatasNumurs;
    }

    public void Print()
    {
        Console.WriteLine($"Uzvārds: {Uzvards}, Mācību kurss: {MacibuKurss}, Atzīmju grāmatas numurs: {AtzimesGramatasNumurs}");
    }
}

public class Aspirant : Student
{
    public string Tema { get; set; }

    public Aspirant(string uzvards, int macibuKurss, int atzimesGramatasNumurs, string tema) : base(uzvards, macibuKurss, atzimesGramatasNumurs)
    {
        Tema = tema;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Tēma: {Tema}");
    }
}


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Student student1 = new Student("Andrejs", 1, 2);
    student1.Print();
    Aspirant aspirant1 = new Aspirant("Andrejs", 1, 2, "vienadojumi");
    aspirant1.Print();
  }
}
