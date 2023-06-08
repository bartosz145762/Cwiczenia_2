using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 5";

        Console.WriteLine("Wczytanie dwóch liczb oraz wypisanie większej");
        Console.WriteLine();

        int a;
        Console.WriteLine("Podaj pierwszą liczbę");
        a = (int)inputValue();

        int b;
        Console.WriteLine("Podaj drugą liczbę");
        b = (int)inputValue();

        Console.WriteLine();

        if (a < b)
        {
            Console.WriteLine("Większa liczba: " + b);
        }
        else
        {
            Console.WriteLine("Większa liczba: " + a);
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