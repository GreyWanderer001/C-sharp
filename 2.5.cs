using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        float userAge = 0.0f;
        
        Console.Write("Ievadiet vecumu: ");
        userAge = float.Parse(Console.ReadLine());
        
        float jupiterYears = 11.86f;
        float jupiterAge = userAge / jupiterYears;
        
        float journeyToJupiter = 9.0f;
        
        float newEarthAge = userAge + journeyToJupiter;
        float newJupiterAge = newEarthAge / jupiterYears;
        
        Console.WriteLine(jupiterAge);
        Console.WriteLine(newEarthAge);
        Console.WriteLine(newJupiterAge);
    }
}
