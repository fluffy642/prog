class Pes : Zvire
{
    public Pes(string nazev, int hmotnost) : base(nazev, hmotnost, "Maso")
    {
        
    }
    public void Stekat()
    {
        Console.WriteLine("Haf!");
    }

    public void Behat()
    {
        Energie -= 40;
        Console.WriteLine("Energie: " + Energie);
    }

}