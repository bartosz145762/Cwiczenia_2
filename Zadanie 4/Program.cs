using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 4";

        Console.WriteLine("Algorytm wypisujący wartość licznika (x) oraz mianownika (y), gdy x/y=a/b + c/d");
        Console.WriteLine();

        int a;
        Console.WriteLine("Podaj liczbę a");
        a = (int)inputValue();

        int b;
        Console.WriteLine("Podaj liczbę b");
        b = (int)inputValue();

        int c;
        Console.WriteLine("Podaj liczbę c");
        c = (int)inputValue();

        int d;
        Console.WriteLine("Podaj liczbę d");
        d = (int)inputValue();

        Console.WriteLine();

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {

            int x = a * d + c * b;
            int y = b * d;

            Console.WriteLine("Wartość x= " + x);
            Console.WriteLine("Wartość y= " + y);
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