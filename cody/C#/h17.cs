class Program
{
    static void Main()
    {
        // FizzBuzz
        /*Console.Write("Zadej cislo: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Buzz");
        } 
        else if (num % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(num);
        }*/


        // Nejblizsi mocnina 2
        /*Console.Write("Zadej cislo: ");
        int num = int.Parse(Console.ReadLine());

        int i = num;
        bool pokracovat = true;
        while (pokracovat)
        {
            for (int j = 1; j < num; j++)
            {
                if (Math.Pow(2, j) == i)
                {
                    Console.WriteLine(i);
                    pokracovat = false;
                }
            }
            i++;
        }*/

        // arr
        /*int[] arr = new int[10];
        int length = 0;
        int num;
        Console.WriteLine("Pravidla:\nNove cislo musi byt vetsi\nPo sudem cislu nasleduje liche a naopak\nKazde nove cislo musi mit 1 cislici jako predchozi");
        for (int i = 0;; i++)
        {
            Console.Write("Zadej cislo: ");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            arr[i] = num;
            length++;
        }

        int res = 0;

        for (int i = 1; i < length; i++)
        {
            int res2 = 0;

            for (int j = arr[i]; j > 0; j /= 10)
            {
                for (int k = arr[i - 1]; k > 0; k /= 10)
                {
                    if (j % 10 == k % 10)
                    {
                        res2++;
                    }
                }
            }

            if (arr[i] < arr[i - 1] || arr[i] % 2 == arr[i - 1] % 2 || res2 == 0)
            {
                res++;
            }
        }

        if (res == 0)
        {
            Console.WriteLine("Cisla splnuji pravidla");
        }
        else
        {
            Console.WriteLine("Cisla pravidla nesplnuji");
        }*/

        Console.Write("Zadej 1. cislo:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Zadej 2. cislo:");
        int num2 = int.Parse(Console.ReadLine());

        int res = 0;

        for (int i = num1; i > 0; i /= 10)
        {
            for (int j = num2; j > 0; j /= 10)
            {
                if (i % 10 == j % 10)
                {
                    res = i % 10;
                    break;
                }
            }
        }
        if (res > 0)
        {
            Console.WriteLine("Cisla maji stejnou cislici a to je " + res);
        }
        else 
        { 
            Console.WriteLine("Neobsahuji");
        }
    }
}