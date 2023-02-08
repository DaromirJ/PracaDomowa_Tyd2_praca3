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

            //    Console.WriteLine($"Zadanie 3 (implementacja ciągu Fibonacciego i wyświetlenie go na ekranie)\r\n");
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

            //    Console.WriteLine($"Zadanie 4 (Po podaniu liczby całkowitej wyświetla piramidę liczb od 1 do podanej liczby)\r\n");

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

            ////Zadanie 5 (Liczby od 1 do 20 wyświetli w 3 potędze)
            //{
            //    Console.WriteLine($"Zadanie 5 (Liczby od 1 do 20 w 3 potędze)\r\n");

            //    for (int a = 1; a <= 20; a++)
            //    {
            //        Console.WriteLine($"Liczba {a} podniesiona do 3 potęgi " + Math.Pow(a, 3));
            //    }
            //}

            ////Zadanie 6 (Dla liczb od 0 do 20 oblicza sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd.)
            //{
            //    Console.WriteLine($"Zadanie 6 (Dla liczb od 0 do 20 oblicza sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd.)");
            //    Console.WriteLine();

            //    double sum = 0;
            //    int n = 20;

            //    for (double i = 1; i <= n; i++)
            //    {
            //        sum = sum + (1 / i);
            //    }

            //    Console.WriteLine($"Suma kolejnych liczb 1 + 1/2 + 1/3 + ... + 1/{n} wynosi: {sum}");
            //    Console.ReadLine();
            //}

            ////Zadanie 7 (Diament z gwiazdek)
            //{
            //    int n = 10;

            //    for (int i = 1; i < n; i++)
            //    {
            //        for (int j = i; j < n; j++)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int k = 1; k <= i; k++)
            //        {
            //            Console.Write("*");
            //        }

            //        for (int f = 1; f < i; f++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }

            //    for (int i = 1; i <= n; i++)
            //    {
            //        for (int j = 1; j < i; j++)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int k = i; k <= n; k++)
            //        {
            //            Console.Write("*");
            //        }

            //        for (int f = i; f < n; f++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }
            //}

            ////Zadanie 8 (Odwrócenie wpisanego tekstu)
            //{
            //    Console.WriteLine("Zadanie 8 (Odwrócenie wpisanego tekstu)");
            //    Console.WriteLine();
            //    Console.WriteLine("Wpisz dowolny ciąg znaków:");

            //    string txt = Console.ReadLine();
            //    int len = txt.Length;

            //    Console.WriteLine();

            //    for (int t = len - 1; t >= 0; t--)
            //    {
            //        Console.Write(txt[t]);
            //    }
            //    Console.WriteLine();
            //}

            //Zadanie 9 (Zmiana liczby dzięsietnej na binarną)
            {
                Console.WriteLine("Zadanie 9 (Zmiana liczby dzięsietnej na binarną)");

                Console.WriteLine("Wpisz dowolną liczbę dziesiętną:");

                int number = int.Parse(Console.ReadLine());
                string revBin = "";
                
                if (number == 0)
                {
                    Console.WriteLine("0 w systemie dziętnym, to w systemie binarnym także 0");
                }
                else
                {
                    for (int i = number; i > 0; i = i / 2)
                    {
                        if (i % 2 == 0)
                        {
                            revBin += "0";
                        }
                        else
                        {
                            revBin += "1";
                        }
                    }

                    Console.Write($"Liczba {number} w systemie binarnym to: ");
                    for (int i = revBin.Length; i > 0; i--)
                    {
                        Console.Write(revBin[i - 1]);
                    }
                    Console.WriteLine(".");
                }
            }

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


        }
    }
}