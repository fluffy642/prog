public class Program
{
    static void Main()
    {
        /*NUhelnik trojuhelnik = new NUhelnik(6, 3);
        NUhelnik petiuhelnik = new NUhelnik(4, 5);
        Console.WriteLine(trojuhelnik.Delka);
        Console.WriteLine(petiuhelnik.Uhlu);
        Console.WriteLine(trojuhelnik.Obsah());
        Console.WriteLine(trojuhelnik.Obvod());
        Console.WriteLine(petiuhelnik.Obsah());
        Console.WriteLine(petiuhelnik.Obvod());*/

        BankAccount ucet = new BankAccount("Petr", 2000, "sporici", 3.5);
        ucet.Vklad(500);
        ucet.ZobrazitInfo();
        ucet.Vyber(1500);
        ucet.ZobrazitInfo();
        ucet.Vyber(1500);
        ucet.ZobrazitInfo();
        ucet.Zurocit();
        ucet.ZobrazitInfo();
    }

}