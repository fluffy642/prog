public class Ucitel
{
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public bool JeTridni = false;
    public Trida Trida { get; set; }

    public Ucitel(string jmeno, int vek)
    {
        Jmeno = jmeno;
        Vek = vek;
        Trida = null;
    }

    public void PridatTridu(Trida trida)
    {
        if (Trida != null)
        {
            Trida.Tridni = null;
            Trida.MaTridniho = false;
        }
        Trida = trida;
        trida.Tridni = this;
        trida.MaTridniho = true;
        JeTridni = true;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Jmeno ucitele: {Jmeno}");
        Console.WriteLine($"Jeho vek: {Vek}");
        if (JeTridni)
        {
            Console.WriteLine($"Je ucitelem tridy: {Trida.Nazev}\n");
        }
        else
        {
            Console.WriteLine($"Ucitel neuci zadnu tridu\n");
        }
        
    }
}