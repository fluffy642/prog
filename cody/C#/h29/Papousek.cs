class Papousek : Zvire
{
    public Papousek(string nazev, int hmotnost) : base(nazev, hmotnost, "Krmivo")
    {

    }

    public void Opakovat(string veta)
    {
        Console.WriteLine(veta);
        Console.WriteLine(veta);
        Console.WriteLine(veta);
    }

    public void Letat()
    {
        Energie -= 40;
        Console.WriteLine("Energie: " + Energie);
    }
}