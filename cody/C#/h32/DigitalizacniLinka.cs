using System.Reflection.Metadata;

class DigitalizacniLinka
{
    public double ZbyvajiciCas {  get; set; }
    public List<Dokument> Seznam = new List<Dokument>();
    public DigitalizacniLinka(int zbyvajiciCas)
    {
        ZbyvajiciCas = zbyvajiciCas;
    }
    public void Zarad(Dokument dokument)
    {
        Seznam.Add(dokument);
    }
    public void Zarad(string nazev, int pocetStran)
    {
        Seznam.Add(new Dokument(nazev, pocetStran));
    }
    public void SpustDavku()
    {
        foreach (var dokument in Seznam)
        {
            if (!dokument.JeDigitalizovan && ZbyvajiciCas > 0)
            {
                ZbyvajiciCas -= dokument.OdhadMinut();
                dokument.Digitalizuj();
                Console.WriteLine("Nazev: " + dokument.Nazev);
                Console.WriteLine("Doba digitalizace: " + dokument.OdhadMinut() + " min");
            }
        }
    }
}