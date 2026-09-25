class Oddeleni
{
    public string Nazev { get; set; }
    public Mistnost Mistnosti { get; set; }
    public Sestricka AktualniSestricka { get; set; }

    public Oddeleni(string nazev, Sestricka aktualnisestricka, int luzka, int obsazeno = 0)
    {
        Nazev = nazev;
        AktualniSestricka = aktualnisestricka;
        aktualnisestricka.OddeleniSestricky = this;
        Mistnosti = new Mistnost(luzka, obsazeno);
    }
    public void PridatLuzka(int luzka)
    {
        if (luzka > 0)
        {
            Mistnosti.Luzka += luzka;
        }
        else
        {
            Console.WriteLine("Spatny vstup");
        }
    }
}
