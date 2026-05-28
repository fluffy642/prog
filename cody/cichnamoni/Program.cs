public class Program
{
    static void Main()
    {
        
        Cichnamon rytir = new Cichnamon("Rytir", 140, 8, "Rytirsky sek", 22, "Rytir rychle sekne mecem", "Svaty uder", 45, "Silny uder mecem s vyuzitim posvatne sily");
        Cichnamon carodej = new Cichnamon("Carodej", 90, 15, "Fireball", 18, "Vystreli rychly ohnivy projektil", "Temna kletba", 55, "Temna magie vysava z protivnika zivotni silu");
        Cichnamon obr = new Cichnamon("Obr", 190, 4, "Uder kladivem", 28, "Provede utok obrovskym kladivem", "Zemetreseni", 35, "Uder o zem ktery vyvolava tlakovou vlnu");
        List<Cichnamon> cichnamony = new List<Cichnamon> {rytir, carodej, obr};

        //Vyber cichnamonu

        Console.Write("Napis sve jmeno: ");
        string jmeno = Console.ReadLine();
        Console.Write("Napis jmeno trenéra: ");
        Trener trener = new Trener(Console.ReadLine(), cichnamony);

        Console.WriteLine("Mame 3 cichnamony: ");
        Console.WriteLine("1. :");
        rytir.VypisInfo();
        Console.WriteLine("2. :");
        carodej.VypisInfo();
        Console.WriteLine("3. :");
        obr.VypisInfo();
        Console.Write("Zvol si jednoho: ");
        Cichnamon cichnamon = cichnamony[int.Parse(Console.ReadLine()) - 1];

        //Zacatek hry

        bool pokracovat = true, dostupneUzraveni = true, dostupnySpecUtok = true;
        int vyber;

        for (int i = 1; pokracovat == true; i++)
        {
            Console.WriteLine("Tvuj tah, moznosti: ");
            Console.WriteLine(" 1 = Zakladni utok (pocita i cichnamonuv bonus)");
            if(i >= 2) Console.WriteLine(" 2 = Specialni utok (nelze pouzivat 2 krat po sobe)");
            Console.WriteLine(" 3 = Uzdraveni (jen jednou za utok)");
            Console.Write("Vyber co chces udelat: ");
            vyber = int.Parse(Console.ReadLine());
            if (vyber == 1)
            {
                cichnamon.ProvestUtokZakl(cichnamon, trener);
                dostupnySpecUtok = true;
            } 
            else if (vyber == 2 && dostupnySpecUtok == true)
            {
                cichnamon.ProvestUtokSpec(cichnamon, trener);
                dostupnySpecUtok = false;
            }
            else if (vyber == 3 && dostupneUzraveni == true)
            {
                cichnamon.Uzdraveni(40);
                dostupnySpecUtok = true;
                dostupneUzraveni = false;
            }
            else
            {
                Console.WriteLine("Spatny vyber");
            }
        }
    }
}