using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Kalkulator średniej arytmetycznej z trzech liczb");
        Console.WriteLine();

        double a;
        Console.WriteLine("Podaj pierwszą liczbę");
        a = inputValue();

        double b;
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();

        double c;
        Console.WriteLine("Podaj trzecią liczbę");
        c = inputValue();

        Console.WriteLine();

        double srednia;
        srednia = (a + b + c) / 3;
        Console.WriteLine("Średnia: " + srednia);

        Console.ReadLine();
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}