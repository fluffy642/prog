using System;
using System.Collections.Generic;

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

        bool pokracovat = true, spravnyVyber = false;
        bool dostupneUzraveni = true, dostupnySpecUtok = true;
        bool dostupneUzraveniTrenera = true, dostupnySpecUtokTrenera = true;
        int vyber = 99, vyberTrenera = 99;

        for (int i = 1; pokracovat == true; i++)
        {
            Console.WriteLine($"\n{i}. tah:");
            Console.WriteLine($"\nTvuj cichnamon: ");
            cichnamon.VypisInfo();
            Console.WriteLine($"\nCichnamon trenera: ");
            cichnatrener.VypisInfo();

            Console.WriteLine("\nTvuj tah, moznosti: ");
            
            while(!spravnyVyber) {
                Console.WriteLine("\n1 = Zakladni utok (pocita i cichnamonuv bonus):");
                cichnamon.UtokZakl.VypisInfo();
                Console.WriteLine("\n2 = Specialni utok (jen co 2 tah, a nelze pouzivat 2 krat po sobe):");
                cichnamon.UtokSpec.VypisInfo();
                Console.WriteLine("\n3 = Uzdraveni o nahodne HP od 20 do 40 (jen jednou za hru)");
                Console.Write("\nVyber co chces udelat: ");
                vyber = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (vyber == 1)
                {
                    cichnamon.ProvestUtokZakl(cichnamon, cichnatrener);
                    Console.WriteLine($"  Byl provedeny zakladni utok \"{cichnamon.UtokZakl.Nazev}\"");
                    dostupnySpecUtok = true;
                    spravnyVyber = true;
                }
                else if (vyber == 2 && dostupnySpecUtok == true && i >= 2)
                {
                    cichnamon.ProvestUtokSpec(cichnamon, cichnatrener);
                    Console.WriteLine($"  Byl provedeny zakladni utok \"{cichnamon.UtokSpec.Nazev}\"");
                    dostupnySpecUtok = false;
                    spravnyVyber = true;
                }
                else if (vyber == 3 && dostupneUzraveni == true)
                {
                    int uzdraveni = new Random().Next(20, 40);
                    cichnamon.Uzdraveni(uzdraveni);
                    Console.WriteLine($"  Bylo provedeno uzdraveni o {uzdraveni} HP");
                    dostupnySpecUtok = true;
                    dostupneUzraveni = false;
                    spravnyVyber = true;
                }
                else
                {
                    Console.WriteLine("  Spatny vyber, skus znovu");
                }
            }

            Console.WriteLine("\nTah trenera: \n");
            spravnyVyber = false;
            while(!spravnyVyber) {
                vyberTrenera = new Random().Next(1, 4);
            
                if (vyberTrenera == 1)
                {
                    cichnatrener.ProvestUtokZakl(cichnatrener, cichnamon);
                    Console.WriteLine($"  Byl provedeny zakladni utok \"{cichnatrener.UtokZakl.Nazev}\"");
                    dostupnySpecUtokTrenera = true;
                    spravnyVyber = true;
                }
                else if (vyberTrenera == 2 && dostupnySpecUtokTrenera == true && i >= 2)
                {
                    cichnatrener.ProvestUtokSpec(cichnatrener, cichnamon);
                    Console.WriteLine($"  Byl provedeny zakladni utok \"{cichnatrener.UtokSpec.Nazev}\"");
                    dostupnySpecUtokTrenera = false;
                    spravnyVyber = true;
                }
                else if (vyberTrenera == 3 && dostupneUzraveniTrenera == true)
                {
                    int uzdraveni = new Random().Next(20, 40);
                    cichnatrener.Uzdraveni(uzdraveni);
                    Console.WriteLine($"  Bylo provedeno uzdraveni o {uzdraveni} HP");
                    dostupnySpecUtokTrenera = true;
                    dostupneUzraveniTrenera = false;
                    spravnyVyber = true;
                }
            }

            Console.WriteLine($"\nKonec {i}. tahu\n");
            spravnyVyber = false;

            if (!cichnamon.JeNazivu())
            {
                pokracovat = false;
                Console.WriteLine($"Hra ukoncena. \n\nZvitezil {trener.Jmeno}");
                trener.Level++;
            } 
            else if(!cichnatrener.JeNazivu())
            {
                pokracovat = false;
                Console.WriteLine($"Hra ukoncena. \n\nZvitezil {jmeno}");
            }
        }
    }
}
