public class Trener
{
    public string Jmeno { get; set; }
    public int Level = 0;
    public List<Cichnamon> VsechnyCichnamony { get; set; } 
    public Cichnamon AktualniCichnamon { get; set; }

    public Trener(string jmeno, List<Cichnamon> vsechnyCichnamony)
    {
        Jmeno = jmeno;
        VsechnyCichnamony = vsechnyCichnamony;
        AktualniCichnamon = VsechnyCichnamony[new Random().Next(0, 3)];
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Trener \"{Jmeno}\"");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Aktualni cichnamon: {AktualniCichnamon}");
    }
}