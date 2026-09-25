class Mistnost
{
    public int Luzka { get; set; }
    public int Obsazeno { get; set; }
    public Mistnost(int luzka, int obsazeno = 0)
    {
        Luzka = luzka;
        if (obsazeno >= luzka)
        {
            Obsazeno = luzka;
        }
        else
        {
            Obsazeno = obsazeno;
        }
    }
    public void PridatPacienta() 
    {
        if (Obsazeno < Luzka)
        {
            Obsazeno++;
        }
        else
        {
            Console.WriteLine("Misnost je obsazena");
        }
    }
    public void OdebratPacienta()
    {
        if (Obsazeno > 0)
        {
            Obsazeno--;
        }
        else
        {
            Console.WriteLine("V mistnosti nikdo neni");
        }

    }
}

