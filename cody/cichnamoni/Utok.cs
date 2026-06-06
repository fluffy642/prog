using System;

public class Utok
{
    public string Nazev { get; set; }
    public int Poskozeni { get; set; }
    public string Popis { get; set; }

    public Utok(string nazev, int poskozeni, string popis)
    {
        Nazev = nazev;
        Poskozeni = poskozeni;
        Popis = popis;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"  Utok \"{Nazev}\"");
        Console.WriteLine($"  Mnozstvi poskozeni: {Poskozeni} HP");
        Console.WriteLine($"  Kratky popis utoku: {Popis}");
    }

}
