using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        double numberOne = 6.5;
        double numberTwo = 4;
        
        Console.WriteLine(Math.Pow(numberOne, numberTwo));
        Console.WriteLine(Math.Ceiling(numberOne));
        
        if (numberOne > numberTwo) {
            Console.WriteLine(numberOne);
        } else {
            Console.WriteLine(numberTwo);
        }
        
    }
}
