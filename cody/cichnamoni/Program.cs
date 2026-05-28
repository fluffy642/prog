public class Program
{
    static void Main()
    {
        
        Cichnamon rytir = new Cichnamon("Rytir", 140, 8, "Rytirsky sek", 22, "Rytir rychle sekne mecem", "Svaty uder", 45, "Silny uder mecem s vyuzitim posvatne sily");
        Cichnamon carodej = new Cichnamon("Carodej", 90, 15, "Fireball", 18, "Vystreli rychly ohnivy projektil", "Temna kletba", 55, "Temna magie vysava z protivnika zivotni silu");
        Cichnamon obr = new Cichnamon("Obr", 190, 4, "Uder kladivem", 28, "Provede utok obrovskym kladivem", "Zemetreseni", 35, "Uder o zem ktery vyvolava tlakovou vlnu");
        List<Cichnamon> cichnamony = new List<Cichnamon> {rytir, carodej, obr};

        //Zacatek hry

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

    }
}