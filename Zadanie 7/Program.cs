using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 7";
        
        Console.WriteLine("Sprawdzanie czy punkt P(x,y) leży w obrębie koła o środku O(0,0) oraz promieniu r");
        Console.WriteLine();

        double x;
        Console.WriteLine("Podaj współrzędną x punktu P:");
        x = inputValue();

        double y;
        Console.WriteLine("Podaj współrzędną y punktu P:");
        y = inputValue();

        double r;
        Console.WriteLine("Podaj promień koła:");
        r = inputValue();

        Console.WriteLine();

        double odlegloscOdCentrum = Math.Sqrt(x * x + y * y);
        if (odlegloscOdCentrum <= r)
        {
            Console.WriteLine("Punkt P leży wewnątrz koła.");
        }
        else
        {
            Console.WriteLine("Punkt P nie leży wewnątrz koła.");
        }

        Console.ReadLine();
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}