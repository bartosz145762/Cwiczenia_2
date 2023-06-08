using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 6";

        Console.WriteLine("Sprawdzenie czy z podanych długości boków można utworzyć trójkąt równoboczny");
        Console.WriteLine();

        int a;
        Console.WriteLine("Podaj długość pierwszego boku");
        a = (int)inputValue();

        int b;
        Console.WriteLine("Podaj długość drugiego boku");
        b = (int)inputValue();

        int c;
        Console.WriteLine("Podaj długość trzeciego boku");
        c = (int)inputValue();

        Console.WriteLine();

        if (a == b && b == c)
        {
            Console.WriteLine("Z podanych długości można utworzyć trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Z podanych długości nie można utworzyć trójkąta równobocznego.");
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