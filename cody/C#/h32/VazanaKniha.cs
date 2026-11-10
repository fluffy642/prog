class VazanaKniha : Dokument
{
    public VazanaKniha(string nazev, int stran) : base(nazev, stran)
    {

    }
    public override double OdhadMinut()
    {
        return 5 + Stran * 1;
    }
}