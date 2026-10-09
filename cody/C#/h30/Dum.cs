using System.IO;

public class Dum : Objekt
{
    public int VymeraZahrady { get; set; }
    public int PocetPater {  get; set; }
    public Dum(int vymeraZahrady, int pocetPater, int cena, string popis) : base(cena, popis)
    {
        VymeraZahrady = vymeraZahrady;
        PocetPater = pocetPater;
    }

    public void VypisInfo()
    {
        Console.WriteLine("Vymera zahrady: " + VymeraZahrady + "m2");
        Console.WriteLine("Pocet pater: " + PocetPater);
        Console.WriteLine("Cena domu: " + Cena + "Kc");
        Console.WriteLine("Popis domu: " + Popis);
    }
}