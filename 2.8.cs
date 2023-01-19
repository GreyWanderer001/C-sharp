using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double numberOne = 12932;
        double numberTwo = -2828472;
        
        numberOne = Math.Sqrt(Math.Abs(numberOne));
        numberTwo = Math.Sqrt(Math.Abs(numberTwo));
        
        if (numberOne < numberTwo) {
            Console.WriteLine("numberOne ir mazaks");
        } else {
            Console.WriteLine("numberTwo ir mazaks");
        }
        
        Console.Write(numberOne + " " + numberTwo);
    }
}
