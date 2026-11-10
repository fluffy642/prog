class Program
{
    static void Main()
    {
        //Dokument dok1 = new Dokument("First", 10);
        //VolneListy dok2 = new VolneListy("Second", 10);
        //VazanaKniha dok3 = new VazanaKniha("Third", 10);

        //Console.WriteLine(dok1.Nazev);
        //Console.WriteLine(dok2.JeDigitalizovan);
        //Console.WriteLine(dok1.OdhadMinut());
        //Console.WriteLine(dok2.OdhadMinut());
        //Console.WriteLine(dok3.OdhadMinut());

        //DigitalizacniLinka linka = new DigitalizacniLinka(150);
        //linka.Zarad(dok1);
        //linka.Zarad("Test", 20);
        //foreach (var item in linka.Seznam)
        //{
        //    Console.WriteLine(item.Nazev);
        //    Console.WriteLine(item.Stran);
        //    Console.WriteLine(item.JeDigitalizovan);
        //}
        //linka.SpustDavku();
        //foreach (var item in linka.Seznam)
        //{
        //    Console.WriteLine(item.Nazev);
        //    Console.WriteLine(item.Stran);
        //    Console.WriteLine(item.JeDigitalizovan);
        //}

        DigitalizacniLinka linka = new DigitalizacniLinka(25);
        linka.Zarad("Uredni dopis", 3);
        linka.Zarad(new VazanaKniha("Matrika", 15));
        linka.Zarad(new VolneListy("Ucetni vykazy", 8));
        linka.Zarad(new Dokument("Mapa", 2));
        linka.SpustDavku();
    }
}