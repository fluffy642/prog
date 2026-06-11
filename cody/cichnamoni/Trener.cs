using System;
using System.Collections.Generic;

public class Trener
{
    public string Jmeno { get; set; }
    public int Level = 0;
    public List<Cichnamon> VsechnyCichnamony { get; set; }
    public Cichnamon AktualniCichnamon { get; set; }

    public Trener(string jmeno, List<Cichnamon> vsechnyCichnamony)
    {
        Jmeno = jmeno;
        VsechnyCichnamony = vsechnyCichnamony.Select(x => new Cichnamon(
            x.Jmeno,
            x.MaxHP,
            x.Bonus,
            x.UtokZakl,
            x.UtokSpec
        )).ToList();
        VyberCichnamona();
    }

    public void VyberCichnamona() 
    {
        AktualniCichnamon = VsechnyCichnamony[new Random().Next(0, VsechnyCichnamony.Count)];
    }

    public void VypisInfo()
    {
        Console.WriteLine($"  Trener \"{Jmeno}\"");
        Console.WriteLine($"  Level: {Level}");
        Console.WriteLine($"  Aktualni cichnamon: {AktualniCichnamon.Jmeno}");
    }
}
