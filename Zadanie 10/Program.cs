using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 10";

        Console.WriteLine("Program wyznaczający ostatnią cyfrę podanej liczby naturalnej");
        Console.WriteLine();

        double liczba;
        Console.WriteLine("Podaj dowolną liczbę naturalną");
        liczba = inputValue();

        double ostatnia = liczba % 10;

        Console.WriteLine();
        Console.WriteLine("Ostatnia cyfra podanej liczby to: " + ostatnia);

        Console.ReadLine();
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}