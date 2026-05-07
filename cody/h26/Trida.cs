public class Trida
{
    public string Nazev { get; set; }
    public int Studenty { get; set; }
    public bool MaTridniho = false;
    public Ucitel Tridni { get; set; }

    public Trida(string nazev, int studenty)
    {
        Nazev = nazev;
        Studenty = studenty;
        Tridni = null;
    }

    public void PridatTridniho(Ucitel ucitel)
    {
        if (Tridni != null)
        {
            Tridni.Trida = null;
            Tridni.JeTridni = false;
        }
        Tridni = ucitel;
        ucitel.Trida = this;
        ucitel.JeTridni = true;
        MaTridniho = true;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Nazev tridy: {Nazev}");
        Console.WriteLine($"Pocet zaku: {Studenty}");
        if (MaTridniho)
        {
            Console.WriteLine($"Tridni ucitel: {Tridni.Jmeno}\n");
        } 
        else
        {
            Console.WriteLine($"Trida nema tridniho ucitele\n");
        }
        
    }
}