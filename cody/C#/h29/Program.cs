class Program
{
    static void Main()
    {
        Pes pes1 = new Pes("chempion", 5);
        Papousek papousek1 = new Papousek("legenda", 1);

        papousek1.Opakovat("Hello");
        pes1.Stekat();
        pes1.Behat();
        papousek1.Letat();
        pes1.Snist("Maso");
        papousek1.Snist("Krmivo");
        pes1.Odpocivej(1);
        papousek1.Odpocivej(1);
    }
}