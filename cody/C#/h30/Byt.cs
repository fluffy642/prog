public class Byt : Objekt
{
    public int Patro { get; set; }
    public Byt(int patro, int cena, string popis) : base(cena, popis)
    {
        Patro = patro;
    }

    public void VypisInfo()
    {
        Console.WriteLine("Patro bytu: " + Patro);
        Console.WriteLine("Cena bytu: " + Cena + "Kc");
        Console.WriteLine("Popis bytu: " + Popis);
    }
}