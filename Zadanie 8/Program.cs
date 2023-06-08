using System;

class MyProgram
{
    static void Main()
    {
        Console.Title = "Zadanie 8";

        Console.WriteLine("Prosty kalkulator 4-działaniowy");
        Console.WriteLine();

        double liczba1;
        Console.WriteLine("Podaj pierwszą liczbę: ");
        liczba1 = inputValue();

        double liczba2;
        Console.WriteLine("Podaj drugą liczbę: ");
        liczba2 = inputValue();

        Console.WriteLine();

        Console.WriteLine("Wybierz działanie:");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");

        int dzialanie;
        dzialanie  = (int)inputValue();

        Console.WriteLine();

        double wynik;

        switch (dzialanie)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 == 0)
                {
                    Console.WriteLine("Nie można dzielić przez zero. Wynik to: " + liczba1 + "/0");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    wynik = liczba1 / liczba2;
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania. Prawidłowy zakres do wyboru to: 1-4");
                Console.ReadLine();
                return;
        }

        Console.WriteLine("Wynik: " + wynik);
        
        Console.ReadLine();
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}