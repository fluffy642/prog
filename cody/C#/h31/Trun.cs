class Trun : Mistnost
{
    public Trun()
    {

    }
    public override void Aktivuj(Hrac hrac)
    {
        hrac.Konec = true;
        Console.WriteLine("Konec hry! Nasel jsi vitezny trun");
    }
}