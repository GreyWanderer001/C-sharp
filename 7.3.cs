using System;

class Vehicle {
  public string Type;
  public int NumTires;
  public int Year;
  public bool Runs;

  public Vehicle(string TypeName, int NumTiresName, int YearName, bool RunsName) {
    Type = TypeName;
    NumTires = NumTiresName;
    Year = YearName;
    Runs = RunsName;
  }
}

class Program {
  public static void Main (string[] args) {
    Vehicle car = new Vehicle("car", 4, 2000, true);
    Vehicle oldcar = new Vehicle("olcdar", 4, 1980, false);
    Vehicle bike = new Vehicle("bike", 2, 2017, true);

    Console.WriteLine(car.Type);
    Console.WriteLine(oldcar.Runs);
    Console.WriteLine(bike.NumTires);
  }
}
