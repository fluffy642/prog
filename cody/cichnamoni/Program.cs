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

        bool ukoncitProgram = false;
        int levelHrace = 0;

        for (int j = 1; ukoncitProgram != true; j++)
        {

            Console.WriteLine($"Mate {cichnamony.Count} cichnamony: ");
            for (int k = 0; k < cichnamony.Count; k++)
            {
                Console.WriteLine($"\n{k + 1}. :");
                cichnamony[k].VypisInfo();
            }
            Console.Write("\nZvol si jednoho: ");
            Cichnamon cichnamon = cichnamony[int.Parse(Console.ReadLine()) - 1];
            Cichnamon cichnatrener = trener.AktualniCichnamon;

            //Zacatek hry

            Console.WriteLine($"\nZacatek {j}. hry");

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

                while (!spravnyVyber)
                {
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
                while (!spravnyVyber)
                {
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
                    cichnatrener.HP = cichnatrener.MaxHP;
                    Console.WriteLine($"\nJsi prisel o cichnamona \"{cichnamon.Jmeno}\"");
                    cichnamony.Remove(cichnamon);
                }
                else if (!cichnatrener.JeNazivu())
                {
                    pokracovat = false;
                    levelHrace++;
                    cichnamon.HP = cichnamon.MaxHP;
                    trener.VsechnyCichnamony.Remove(cichnatrener);
                    Console.WriteLine($"Hra ukoncena. \n\nZvitezil {jmeno}");
                    Console.Write($"\nChces pridat cichnamona? (napis ano nebo ne): ");
                    string odpovedPridani = Console.ReadLine();
                    if (odpovedPridani == "ano" || odpovedPridani == "ANO")
                    {
                        Console.WriteLine($"Napis jmeno cichnamona:");
                        string noveJmeno = Console.ReadLine();
                        Console.WriteLine($"Napis maximanli HP cichnamona:");
                        int noveMaxHP = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Napis bonus pri kazdem utoku cichnamona:");
                        int novyBonus = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Napis nazev zakladniho utoku:");
                        string novyZaklUtokNazev = Console.ReadLine();
                        Console.WriteLine($"Napis mnozstvi poskozeni zakladniho utoku:");
                        int noveZaklUtokPoskozeni = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Napis kratky popis zakladniho utoku:");
                        string novyZaklUtokPopis = Console.ReadLine();
                        Console.WriteLine($"Napis nazev specialniho utoku:");
                        string novySpecUtokNazev = Console.ReadLine();
                        Console.WriteLine($"Napis mnozstvi poskozeni specialniho utoku:");
                        int noveSpecUtokPoskozeni = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Napis kratky popis specialniho utoku:");
                        string novySpecUtokPopis = Console.ReadLine();
                        cichnamony.Add(new Cichnamon(noveJmeno, noveMaxHP, novyBonus, novyZaklUtokNazev, noveZaklUtokPoskozeni, novyZaklUtokPopis, novySpecUtokNazev, noveSpecUtokPoskozeni, novySpecUtokPopis));
                    }
                }
                
            }
            if (cichnamony.Count == 0)
            {
                ukoncitProgram = true;
            }
            Console.Write("\nChcete ukoncit program? (napis ano nebo ne):");
            string odpovedUkonceni = Console.ReadLine();
            if (odpovedUkonceni == "ano" || odpovedUkonceni == "ANO")
            {
                ukoncitProgram = true;
            }
            Console.WriteLine($"\nKonec {j}. hry\n");
        }

        
    }
}
