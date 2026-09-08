public class Program
{
    static void Main()
    {
        Trida trida1 = new Trida("IT2B", 27);
        Trida trida2 = new Trida("LG1A", 22);
        Ucitel ucitel1 = new Ucitel("Drimal", 32);
        Ucitel ucitel2 = new Ucitel("Kalcikova", 56);

        trida1.PridatTridniho(ucitel1);
        trida1.PridatTridniho(ucitel2);
        ucitel1.PridatTridu(trida2);
        trida1.VypisInfo();
        trida2.VypisInfo();
        ucitel1.VypisInfo();
        ucitel2.VypisInfo();

        

    }
}