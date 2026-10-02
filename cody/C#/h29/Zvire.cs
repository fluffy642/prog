class Zvire
{
    public string Nazev {  get; set; }
    public int Hmotnost {  get; set; }
    public int Energie = 100;
    public bool Nazivu = true;
    public string PovoleneJidlo { get; set; }

    public Zvire(string nazev, int hmotnost, string povoleneJidlo) 
    {
        Hmotnost = hmotnost;
        Nazev = nazev;
        PovoleneJidlo = povoleneJidlo;
    }

    public void Snist(string jidlo)
    {
        if (jidlo == PovoleneJidlo)
        {
            Console.WriteLine("Navysila se energie");
            Energie += 20;
            Console.WriteLine("Energie: " + Energie);
        }
    }

    public void Odpocivej(int hodiny)
    {
        Energie += hodiny * 10;
        Console.WriteLine("Energie: " + Energie);
    }

}