using System;

namespace PracaDomowa
{
    public class Tyd2Praca3
    {
        static void Main(string[] args)
        {

            ////Zadanie 1 (Ile jest liczb pierwszych w liczbie 100)

            //int counter = 0;
            //    int a = 20;

            //    for (int i = 2; i <= a; i++)
            //    {
            //        bool Prime = true;

            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                Prime = false;
            //                break;
            //            }

            //        }

            //        if (Prime)
            //            counter++;
            //    }
            //    Console.WriteLine($"Zadanie 1 (Ile jest liczb pierwszych w liczbie 100)");
            //    Console.WriteLine($"W liczbie 100 jest {counter} liczb pierwszych");
            //    Console.ReadLine();


            ////Zadanie 2 (Lista liczb parzystych w liczbie 1000)
            //{
            //    Console.WriteLine($"Zadanie 2 (Lista liczb parzystych w liczbie 1000)\r\n");

            //    int n = 0;

            //    do
            //    {
            //        if (n % 2 == 0)
            //        {
            //            Console.Write($"{n}, ");
            //        }
            //        n++;
            //    } while (n <= 1000);
            //    Console.ReadLine();
            //}

            ////Zadanie 3 (implementacja ciąg Fibonacciego i wyświetlenie go na ekranie)
            //{
            //    int n = 10;
            //    int a = 0;
            //    int b = 1;

            //    Console.WriteLine($" Zadanie 3 (implementacja ciągu Fibonacciego i wyświetlenie go na ekranie)\r\n");
            //    Console.WriteLine(a);

            //    for (int i = 0; i <= n; i++)
            //    {
            //        Console.WriteLine(b);
            //        b += a;
            //        a = b - a;
            //    }
            //}

            ////Zadanie 4 (Po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby)
            //{
            //    Console.WriteLine("Podaj dowolną liczbę całkowitą\r\n");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine();

            //    Console.WriteLine($" Zadanie 4 (Po podaniu liczby całkowitej wyświetla piramidę liczb od 1 do podanej liczby)\r\n");

            //    int number = 1;

            //    for (int i = 1; i < a; i++)
            //    {
            //        for (int j = 1; j < i; j++)
            //        {
            //            if (number > a)
            //                break;

            //            Console.Write(" " + number);
            //            number++;
            //        }
            //        if (number > a)
            //            break;

            //        Console.WriteLine();
            //    }
            //}

            //Zadanie 5 (czy możesz się ubiegać o stanowisko: posła, sentaora, premiera, prezydenta?)
            {
                int age;

                Console.WriteLine("Zadanie 5 (czy możesz się ubiegać o stanowisko: posła, sentaora, premiera, prezydenta?)");

                Console.WriteLine("Podaj twój wiek.");
                int.TryParse(Console.ReadLine(), out age);

                string posel = age >= 21 ? "\r\n posła" : "";
                string senat = age >= 30 ? "\r\n senatora \r\n premiera" : "";
                string president = age >= 35 ? "\r\n prezydenta" : "";

                Console.WriteLine($"Masz {age} lat, więc możesz się ubiegać o stanowisko: {posel}{senat}{president}");
                Console.ReadLine();
            }

            ////Zadanie 6 (Kategorie wzrostu)
            //{
            //    int growth;

            //    Console.WriteLine("Zadanie 6 (Jakiej kategorii jest twój wzrost?)");

            //    Console.WriteLine("Podaj twój wzrost w centymetrach.");
            //    int.TryParse(Console.ReadLine(), out growth);

            //    string result = growth switch
            //    {
            //        > 200 => "bardzo wysoki",
            //        > 180 => "wysoki",
            //        > 168 => "średniego wzrostu",
            //        > 150 => "niskiego wzrostu",
            //        > 140 => "kurduplem",
            //        <= 140 => "karłem",
            //    };

            //    Console.WriteLine($"Masz {growth} cm wzrostu, więc jesteś {result}");
            //    Console.ReadLine();
            //}

            ////Zadanie 7 (Największa z 3-ech liczb)
            //{
            //int n = 10;

            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    for (int f = 1; f <= i; f++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = i; k <= n; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    for (int f = i; f < n; f++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            ////Zadanie 8 (prawo do miejsca na studiach)
            //{
            //    Console.WriteLine("Zadanie 8 (prawo do miejsca na studiach)");

            //    Console.WriteLine($"By sprawdzić czy możesz ubiegać się o miejsce na studiach \r\npodaj oceny z matury z podanych niżej przedmiotów: ");
            //    Console.WriteLine("z matematyki: ");
            //    int matma = int.Parse(Console.ReadLine());

            //    Console.WriteLine("z fizyki: ");
            //    int fizyka = int.Parse(Console.ReadLine());

            //    Console.WriteLine("z chemii: ");
            //    int chemia = int.Parse(Console.ReadLine());

            //    string result;
            //    {
            //        if ((matma > 70 && fizyka > 55 && chemia > 45 && (matma + fizyka + chemia > 180))
            //            || (matma + fizyka > 150)
            //            || (matma + chemia > 150))
            //        {
            //            result = "może się";
            //        }
            //        else
            //        {
            //            result = "nie może się";
            //        }
            //    }

            //    Console.WriteLine($"Kandydat {result} ubiegać o miejsce na studiach");
            //}

            ////Zadanie 9 (określenie typu temperatury)
            //{
            //    Console.WriteLine("Zadanie 9 (określenie typu temperatury)");

            //    Console.WriteLine($"Podaj jaka panuje temperatura na dworze:");
            //    int temp = int.Parse(Console.ReadLine());

            //    string result;
            //    {
            //        if (temp >= 40)
            //        {
            //            result = "A weź wyprowadzam się na Alaskę";
            //        }
            //        else if (temp >= 30)
            //        {
            //            result = "Zaczyna być słabo, bo gorąco";
            //        }
            //        else if (temp >= 20)
            //        {
            //            result = "W sam raz";
            //        }
            //        else if (temp >= 10)
            //        {
            //            result = "Chłodno";
            //        }
            //        else if (temp >= 0)
            //        {
            //            result = "Zimno";
            //        }
            //        else
            //        {
            //            result = "Cholernie piździ";
            //        }
            //    }

            //    Console.WriteLine($"Jaka pogoda? {result}");
            //}

            ////Zadanie 10 (możliwość zbudowania trójkąta z podanych długości boków)
            //{
            //    Console.WriteLine("Zadanie 10 (możliwość zbudowania trójkąta z podanych długości boków)");

            //    Console.WriteLine($"Sprawdzimy czy z podanych przez ciebie długości boków można zbudować trójkąt.\r\nPodaj długości następujących boków:");
            //    Console.WriteLine("długość boku a: ");
            //    int a = int.Parse(Console.ReadLine());

            //    Console.WriteLine("długość boku b: ");
            //    int b = int.Parse(Console.ReadLine());

            //    Console.WriteLine("długość boku c: ");
            //    int c = int.Parse(Console.ReadLine());

            //    string result;
            //    {
            //        if ((a + b > c) && (a + c > b) && (b + c > a))
            //        {
            //            result = "można";
            //        }
            //        else
            //        {
            //            result = "nie można";
            //        }
            //    }

            //    Console.WriteLine($"Z podanych długości boków {result} zbudować trójką");
            //}

            ////Zadanie 11 (Kategorie wzrostu)
            //{
            //    int ocena;

            //    Console.WriteLine("Zadanie 11 (ocena słownie)");

            //    Console.WriteLine("Podaj otrzymaną ocenę");
            //    int.TryParse(Console.ReadLine(), out ocena);

            //    switch (ocena)
            //    {
            //        case 1:
            //            Console.WriteLine("Niedostateczny");
            //            break;
            //        case 2:
            //            Console.WriteLine("Dopuszczający");
            //            break;
            //        case 3:
            //            Console.WriteLine("Dostateczny");
            //            break;
            //        case 4:
            //            Console.WriteLine("Dobry");
            //            break;
            //        case 5:
            //            Console.WriteLine("Bardzo dobry");
            //            break;
            //        case 6:
            //            Console.WriteLine("Celujący");
            //            break;
            //    }

            //    Console.ReadLine();
            //}

            ////Zadanie 12 (Nazwy dni tygodnia)
            //{
            //    int dayNo;

            //    Console.WriteLine("Zadanie 12 (Nazwy dni tygodnia)");

            //    Console.WriteLine("Podaj numer dnia tygodnia, a podam ci jego nazwę");
            //    int.TryParse(Console.ReadLine(), out dayNo);

            //    switch (dayNo)
            //    {
            //        case 1:
            //            Console.WriteLine("Dzień nr 1, to poniedziałek");
            //            break;
            //        case 2:
            //            Console.WriteLine("Dzień nr 2, to wtorek");
            //            break;
            //        case 3:
            //            Console.WriteLine("Dzień nr 3, to środa");
            //            break;
            //        case 4:
            //            Console.WriteLine("Dzień nr 4, to czwartek");
            //            break;
            //        case 5:
            //            Console.WriteLine("Dzień nr 5, to piątek");
            //            break;
            //        case 6:
            //            Console.WriteLine("Dzień nr 6, to sobota");
            //            break;
            //        case 7:
            //            Console.WriteLine("Dzień nr 7, to niedziela");
            //            break;
            //    }

            //    Console.ReadLine();
            //}

            ////Zadanie 13 (operacje na dwóch podanych liczbach)
            //{
            //    Console.WriteLine("Podaj pierwszą liczbę całkowitą:");
            //    int no1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Podaj drugą liczbę całkowitą:");
            //    int no2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Podaj numer operacji do wykonania:");
            //    Console.WriteLine("1. Dodawanie");
            //    Console.WriteLine("2. Odejmowanie");
            //    Console.WriteLine("3. Mnożenie");
            //    Console.WriteLine("4. Dzielenie");

            //    int operation = int.Parse(Console.ReadLine());

            //    double result;

            //    switch (operation)
            //    {
            //        case 1:
            //            result = no1 + no2;
            //            Console.WriteLine($"Twój wynik to: {result}");
            //            break;
            //        case 2:
            //            result = no1 - no2;
            //            Console.WriteLine($"Twój wynik to: {result}");
            //            break;
            //        case 3:
            //            result = no1 * no2;
            //            Console.WriteLine($"Twój wynik to: {result}");
            //            break;
            //        case 4:
            //            if (no2 == 0)
            //            {
            //                Console.WriteLine("Dzielenie przez 0 jest zabronione!");
            //                break;
            //            }
            //            result = (double)no1 / no2;
            //            Console.WriteLine($"Twój wynik to: {result}");
            //            break;
            //        default:
            //            Console.WriteLine("Wybrana operacja nie jest dostępna");
            //            break;
            //    }
            //}


        }
    }
}