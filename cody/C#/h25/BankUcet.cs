public class BankAccount
{
    public string Jmeno { get; set; }
    public double Zustatek { get; set; }
    public string TypUctu { get; set; }
    public double Sazba { get; set; }
    public List<string> Tranzakce;

    public BankAccount(string jmeno, double zustatek, string typuctu, double sazba)
    {
        Jmeno = jmeno;
        Zustatek = zustatek;
        TypUctu = typuctu;
        Tranzakce = new List<string>();
        Sazba = sazba;
    }

    public void Vklad(double penize)
    {
        Zustatek += penize;
        Tranzakce.Add($"    Bylo vlozeno +{penize} Kc");
    }

    public void Vyber(double penize)
    {
        if (Zustatek > penize)
        {
            Zustatek -= penize;
            Tranzakce.Add($"    Bylo vybrano -{penize} Kc");
        }
        else
        {
            Console.WriteLine("Neplatna operace");
        }
    }

    public void HistorieTranzakce()
    {
        foreach (string item in Tranzakce)
        {
            Console.WriteLine(item);
        }
    }

    public void Zurocit()
    {
        if (TypUctu == "sporici")
        {
            Zustatek += Sazba * Zustatek / 100;
            Tranzakce.Add($"    Zustatek byl zurocen na castku {Sazba} %");
        }
        else
        {
            Console.WriteLine("Nemate sporici ucet");
        }

    }

    public void ZobrazitInfo()
    {
        Console.WriteLine($"Hostitel uctu: {Jmeno}");
        Console.WriteLine($"Typ uctu: {TypUctu}");
        Console.WriteLine($"Aktualni zustatek: {Zustatek}");
        Console.WriteLine($"Historie tranzakci: ");
        HistorieTranzakce();
        Console.WriteLine("\n");
    }
}