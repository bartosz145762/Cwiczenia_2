using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 3";

        Console.WriteLine("Kalkulator BMI");
        Console.WriteLine();

        double waga;
        Console.WriteLine("Podaj swoją wagę");
        waga = inputValue();
        
        double wzrost;
        Console.WriteLine("Podaj swój wzrost w metrach");
        wzrost = inputValue();
        
        Console.WriteLine();

        double BMI;
        BMI = waga / Math.Pow(wzrost, 2);
        Console.WriteLine("Twoje BMI wynosi: " + BMI);

        Console.ReadLine();
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}