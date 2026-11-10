class VolneListy : Dokument
{
    public VolneListy(string nazev, int stran) : base(nazev, stran)
    {

    }
    public override double OdhadMinut()
    {
        return Stran * 2;
    }
}