class Program
{
    static void Main()
    {
        /*bool pokracovat = true;
        while (pokracovat)
        {
            try
            {
                Console.Write("Jaka cena listku: ");
                double cena = double.Parse(Console.ReadLine());
                Console.Write("Kolik zaku: ");
                double zaky = double.Parse(Console.ReadLine());
                Console.WriteLine($"Kazdy zak platil {cena / zaky} Kc");
                pokracovat = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Musis zadat cislo");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nulou delit nelze");
            }
        }*/
        Sestricka sestra1 = new Sestricka("Klara", 50000);
        Oddeleni oddeleni1 = new Oddeleni("BP1", sestra1, 50, 60);
        sestra1.JakyPlat();
        sestra1.ZvyseniPlatu(5000);
        sestra1.JakyPlat();
        Console.WriteLine(sestra1.OddeleniSestricky);
        oddeleni1.PridatLuzka(50);
        Console.WriteLine(oddeleni1.Mistnosti.Luzka);
        Console.WriteLine(oddeleni1.Mistnosti.Obsazeno);

    }
}