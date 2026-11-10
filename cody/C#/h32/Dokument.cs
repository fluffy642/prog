class Dokument
{
    public string Nazev {  get; set; }
    public int Stran { get; set; }
    public bool JeDigitalizovan = false;
    public Dokument(string nazev, int stran) {
        Nazev = nazev;
        Stran = stran;
    }
    public virtual double OdhadMinut() {
        return Stran * 1.5;
    }

    public void Digitalizuj()
    {
        JeDigitalizovan = true;
    }
}