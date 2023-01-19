using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double numberOne = 12932;
        double numberTwo = -2828472;
        
        numberOne = Math.Sqrt(numberOne);
        numberTwo = Math.Sqrt(numberTwo);
        
        if (Double.IsNaN(numberOne) && Double.IsNaN(numberTwo)) {
            Console.WriteLine("Error");
        } else if (Double.IsNaN(numberOne)) {
            Console.WriteLine("numberTwo ir mazaks");
        } else if (Double.IsNaN(numberTwo)) {
            Console.WriteLine("numberOne ir mazaks");
        } else {
            if (numberOne < numberTwo) {
                Console.WriteLine("numberOne ir mazaks");
            } else if (numberOne > numberTwo) {
                Console.WriteLine("numberTwo ir mazaks");
            }
        }        
        Console.Write(numberOne + " " + numberTwo);
    }
}
