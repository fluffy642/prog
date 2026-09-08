using System;
using System.Numerics;

class Program
{
    static bool Prvocislo(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 2; j < arr[i]; j++)
            {
                if (arr[i] % j == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    static bool StejnyDelitel(int[] arr)
    {
        int min = arr.Min();
        for (int i = 1; i < min; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {

                if (arr[j] % i != 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    static bool ObsahujeSixSeven(int num)
    {
        do
        {
            if (num % 10 == 7 || num % 10 == 6)
            {
                return true;
            }
            num /= 10;
        } while (num > 0);
        return false;
    }

    static void PocetOvci(double startOvci, double deadOvci, double newOvci, double roku)
    {
        if (startOvci < 0 || deadOvci < 0 || deadOvci > 1 || newOvci < 0)
        {
            Console.WriteLine("CHYBA");
            return;
        }
        double res = (double) startOvci * (1 - deadOvci) + newOvci;
        for (int i = 1; i <= roku; i++)
        {
            Console.WriteLine($"Rok {i}: {Math.Round(res)}");
            res = (double) res * (1 - deadOvci) + newOvci;
        }
    }

    static bool JeDelitel(int num1, int num2)
    {
        if (num2 % num1 == 0)
        {
            return true;
        }
        return false;
    }

    static int NSD(int num1, int num2)
    {
        int res = 0;
        int min;

        if (num1 > num2)
        {
            min = num2;
        }
        else
        {
            min = num1;
        }

        for (int i = 1; i <= min; i++)
        {
            if (num2 % i == 0 && num1 % i == 0)
            {
                res = i;
            }
        }
        return res;
    }

    static void Main()
    {
        /*Console.Write("Napis cislo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine($"Cislo: {x}");*/

        /*int[] arr = { 2, 15 };
        Console.WriteLine(Prvocislo(arr));
        Console.WriteLine(StejnyDelitel(arr));*/

        Console.WriteLine(NSD(12, 18));
        Console.WriteLine(NSD(8, 20));
    }
}