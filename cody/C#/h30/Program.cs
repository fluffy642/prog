public class Program
{
    static void Main()
    {
        /*Byt byt1 = new Byt(5, 30000, "Byt v Bystrci");
        Dum dum1 = new Dum(100, 2, 5000000, "Dum v Praze");
        dum1.VypisInfo();
        byt1.VypisInfo();*/

        /*Hrac hrac1 = new Hrac("Bojovnik");
        hrac1.Utok();
        hrac1.Utok(20);
        hrac1.Utok("mece");
        hrac1.Utok(20, "mece");*/

        Matematika x = new Matematika();
        x.Max(5, 8);
        x.Max(15, 8, 1);
        int[] cisla = { 1, 7, 3, 54 };
        x.Max(cisla);
    }
}