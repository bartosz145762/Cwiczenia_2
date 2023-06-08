using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Wyliczenie promienia oraz obowodu koła z jego pola");
        Console.WriteLine();

        double pi;
        pi = Math.PI;
       
        double pole;
        Console.WriteLine("Podaj pole koła");
        pole = inputValue();


        double promien;
        promien = Math.Sqrt(pole / pi);
        Console.WriteLine();
        Console.WriteLine("Promień: " + promien);

        double obwod;
        obwod = 2 * pi * promien;
        Console.WriteLine("Obwód: " +  obwod);

        Console.ReadLine();
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}