class Program
{
    static bool Trojuhelnik(double a, double b, double c)
    {
        return (a + b > c && a + c > b && b + c > a);
    }

    static bool Cislo(int num)
    {
        bool res = true;
        while (num != 0)
        {
            if (!(num % 10 == 1 || num % 10 == 0))
            {
                res = false;
                break;
            }
            num /= 10;
        }
        return res;
    }
    static void Main()
    {
        // Trojuhelnik
        /*Console.Write("1: Strana: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("2: Strana: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("3: Strana: ");
        double c = double.Parse(Console.ReadLine());

        if (Trojuhelnik(a, b, c))
        {
            Console.Write("Trojuhelnik lze sestrojit");
        }
        else
        {
            Console.Write("Trojuhelnik nelze sestrojit");
        }*/


        // Cislo z 0 a 1
        /*Console.Write("Zadej cislo: ");
        int num = int.Parse(Console.ReadLine());

        if (Cislo(num))
        {
            Console.WriteLine("1 a 0");
        }
        else
        {
            Console.WriteLine("Neni");
        }*/


        // Kamen nuzky papir
        Console.Write("1. hrac napis kamen, nuzky nebo papir: ");
        string prvni = Console.ReadLine();
        Console.Write("2. hrac napis kamen, nuzky nebo papir: ");
        string druhy = Console.ReadLine();

        string vyhral = "nikdo";
        if (prvni == druhy)
        {
            vyhral = "nikdo";
        }
        else if (prvni == "kamen")
        {
            if (druhy == "nuzky")
            {
                vyhral = prvni;
            }
            else if (druhy == "papir")
            {
                vyhral = druhy;
            }
        }
        else if (prvni == "papir")
        {
            if (druhy == "nuzky")
            {
                vyhral = druhy;
            }
            else if (druhy == "kamen")
            {
                vyhral = prvni;
            }
        }
        else if (prvni == "nuzky")
        {
            if (druhy == "papir")
            {
                vyhral = prvni;
            }
            else if (druhy == "kamen")
            {
                vyhral = druhy;
            }
        }

        if (vyhral == "nikdo")
        {
            Console.WriteLine("Mate stejne vstupy");
        }
        else if (vyhral == prvni)
        {
            Console.WriteLine("Vyhral 1. hrac");
        }
        else if (vyhral == druhy)
        {
            Console.WriteLine("Vyhral 2. hrac");
        }
    }   
}