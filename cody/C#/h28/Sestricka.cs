class Sestricka
{
    public string Jmeno { get; set; }
    private int Plat { get; set; }
    public Oddeleni OddeleniSestricky { get; set; }

    public Sestricka(string jmeno, int plat, Oddeleni oddeleni = null)
    {
        Jmeno = jmeno;
        Plat = plat;
        oddeleni.AktualniSestricka.OddeleniSestricky = null;
        OddeleniSestricky = oddeleni;
        oddeleni.AktualniSestricka = this;
    }

    public void ZvyseniPlatu(int plat)
    {
        Plat += plat;
    }
    public void SnizeniPlatu(int plat)
    {
        if (Plat >= plat) 
        {
            Plat -= plat;
        } 
        else
        {
            Console.WriteLine("Neni mozny zaporny plat");
        }
    }
    public int JakyPlat() 
    {
        return Plat;
    }
    public void PridatOddeleni(Oddeleni oddeleni) 
    {
        oddeleni.AktualniSestricka.OddeleniSestricky = null;
        OddeleniSestricky = oddeleni;
        oddeleni.AktualniSestricka = this;
    }
}
