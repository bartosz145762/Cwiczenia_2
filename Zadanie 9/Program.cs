using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 9";

        Console.WriteLine("Algorytm pobierający wartości a, b, c i zamieniający je miejscami - odpowiednio a->b, b->c, c->a");
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

        Console.WriteLine("Wartości przed zamianą:");
        Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
        Console.WriteLine();

        a = a + b + c;
        b = a - (b + c);
        c = a - (b + c);
        a = a - (b + c);

        Console.WriteLine("Wartości po zamianie:");
        Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

        Console.ReadLine();
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}