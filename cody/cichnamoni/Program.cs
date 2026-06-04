using System.ComponentModel.Design;

public class Program
{
    static void Main()
    {

        Cichnamon rytir = new Cichnamon("Rytir", 140, 8, "Rytirsky sek", 22, "Rytir rychle sekne mecem", "Svaty uder", 45, "Silny uder mecem s vyuzitim posvatne sily");
        Cichnamon carodej = new Cichnamon("Carodej", 90, 15, "Fireball", 18, "Vystreli rychly ohnivy projektil", "Temna kletba", 55, "Temna magie vysava z protivnika zivotni silu");
        Cichnamon obr = new Cichnamon("Obr", 190, 4, "Uder kladivem", 28, "Provede utok obrovskym kladivem", "Zemetreseni", 35, "Uder o zem ktery vyvolava tlakovou vlnu");
        List<Cichnamon> cichnamony = new List<Cichnamon> { rytir, carodej, obr };

        //Vyber cichnamonu

        Console.Write("Napis sve jmeno: ");
        string jmeno = Console.ReadLine();
        Console.Write("Napis jmeno trenera: ");
        Trener trener = new Trener(Console.ReadLine(), cichnamony);

        Console.WriteLine("Mame 3 cichnamony: ");
        Console.WriteLine("\n1. :");
        rytir.VypisInfo();
        Console.WriteLine("\n2. :");
        carodej.VypisInfo();
        Console.WriteLine("\n3. :");
        obr.VypisInfo();
        Console.Write("\nZvol si jednoho: ");
        Cichnamon cichnamon = cichnamony[int.Parse(Console.ReadLine()) - 1];
        Cichnamon cichnatrener = trener.AktualniCichnamon;

        //Zacatek hry

        Console.WriteLine($"\nZacatek hry");

        bool pokracovat = true;
        bool dostupneUzraveni = true, dostupnySpecUtok = true;
        bool dostupneUzraveniTrenera = true, dostupnySpecUtokTrenera = true;
        int vyber, vyberTrenera;

        for (int i = 1; pokracovat == true; i++)
        {
            Console.WriteLine($"\nTvuj cichnamon: ");
            cichnamon.VypisInfo();
            Console.WriteLine($"\nCichnamon trenere: ");
            cichnatrener.VypisInfo();

            Console.WriteLine("\nTvuj tah, moznosti: ");
            Console.WriteLine(" 1 = Zakladni utok (pocita i cichnamonuv bonus)");
            Console.WriteLine(" 2 = Specialni utok (jen co 2 tah, a nelze pouzivat 2 krat po sobe)");
            Console.WriteLine(" 3 = Uzdraveni (jen jednou za utok)");
            Console.Write("Vyber co chces udelat: ");
            vyber = int.Parse(Console.ReadLine());
            if (vyber == 1)
            {
                cichnamon.ProvestUtokZakl(cichnamon, cichnatrener);
                Console.Write($"Byl provedeny zakladni utok {cichnamon.UtokZakl.Nazev}");
                dostupnySpecUtok = true;
            }
            else if (vyber == 2 && dostupnySpecUtok == true && i >= 2)
            {
                cichnamon.ProvestUtokSpec(cichnamon, cichnatrener);
                Console.Write($"Byl provedeny zakladni utok {cichnamon.UtokSpec.Nazev}");
                dostupnySpecUtok = false;
            }
            else if (vyber == 3 && dostupneUzraveni == true)
            {
                int uzdraveni = new Random().Next(20, 40);
                cichnamon.Uzdraveni(uzdraveni);
                Console.Write($"Bylo provedeno uzdraveni o {uzdraveni} HP");
                dostupnySpecUtok = true;
                dostupneUzraveni = false;
            }
            else
            {
                Console.WriteLine("Spatny vyber");
            }

            Console.WriteLine("\nTah trenera: ");
            vyberTrenera = new Random().Next(1, 4);

            if (vyberTrenera == 1)
            {
                cichnatrener.ProvestUtokZakl(cichnatrener, cichnamon);
                Console.Write($"Byl provedeny zakladni utok {cichnatrener.UtokZakl.Nazev}");
                dostupnySpecUtokTrenera = true;
            }
            else if (vyberTrenera == 2 && dostupnySpecUtokTrenera == true && i >= 2)
            {
                cichnatrener.ProvestUtokSpec(cichnatrener, cichnamon);
                Console.Write($"Byl provedeny zakladni utok {cichnatrener.UtokSpec.Nazev}");
                dostupnySpecUtokTrenera = false;
            }
            else if (vyberTrenera == 3 && dostupneUzraveniTrenera == true)
            {
                int uzdraveni = new Random().Next(20, 40);
                cichnatrener.Uzdraveni(uzdraveni);
                Console.Write($"Bylo provedeno uzdraveni o {uzdraveni} HP");
                dostupnySpecUtokTrenera = true;
                dostupneUzraveniTrenera = false;
            }
            else
            {
                Console.Write("Spatny vyber trenera");
            }

            Console.Write($"Konec {i}. tahu");

            if (cichnamon.HP <= 0)
            {
                pokracovat = false;
                Console.Write($"Hra ukoncena. \nZvitezil {trener.Jmeno}");
            } 
            else if(cichnatrener.HP <= 0)
            {
                pokracovat = false;
                Console.Write($"Hra ukoncena. \nZvitezil {jmeno}");
            }
        }
    }
}