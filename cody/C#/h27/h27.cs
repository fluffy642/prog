class Program
{
    static int Pokuta(List<int> rychlosti)
    {
        const int MaxRychlost = 50;
        int res = 0;
        int celkemNad = 0;
        bool vsechnyJizdyNad = true;
        for (int i = 0; i < rychlosti.Count; i++)
        {
            if (rychlosti[i] > MaxRychlost)
            {
                res += 500;
                celkemNad++;
            }
            else
            {
                vsechnyJizdyNad = false;
            }
        }
        if (celkemNad >= 10)
        {
            res += 1000;
        }
        if (vsechnyJizdyNad && rychlosti.Count >= 6)
        {
            res += 6000;
        }
        return res;
    }

    static int Vyplata(int smlouva, int odpracovano)
    {
        const int Mzda = 220;
        const int Prescas = 350;

        int odpracovanoPrescas = odpracovano - smlouva;

        return smlouva * Mzda + odpracovanoPrescas * Prescas;
    }
    static void Automat()
    {
        List<int> validniMince = new List<int> {1, 2, 5, 10, 20, 50};
        int mince;
        int cena = 35;
        while (true)
        {
            Console.WriteLine("Vloz mince: ");
            mince = int.Parse(Console.ReadLine());
            if (!validniMince.Contains(mince))
            {
                Console.WriteLine("Neplatna mince");
                continue;
            }
            cena -= mince;
            if (cena <= 0)
            {
                Console.WriteLine("Dostavas napoj");
                break;
            }
        }
    }
    static bool ValidniObjednavky(int[] objednavky)
    {
        foreach (int objednavka in objednavky)
        {
            if (objednavka >= 0)
            {
                continue;
            }
            return false;
        }
        return true;
    }
    static void Main()
    {
        //List<int> rychlosti = new List<int>{60, 70, 80, 60, 70, 80, 60, 70, 80, 10, 80};
        //Console.WriteLine(Pokuta(rychlosti));

        //Console.WriteLine(Vyplata(18, 26));

        //Automat();

        int[] objednavky = { 450, 1, 720, 1300, -5, 280 };
        Console.WriteLine(ValidniObjednavky(objednavky));
    }
}
