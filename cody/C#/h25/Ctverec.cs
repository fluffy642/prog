public class NUhelnik
{
    public int Uhlu { get; set; }
    public int Delka { get; set; }

    public NUhelnik(int delka, int uhlu)
    {
        Delka = delka;
        Uhlu = uhlu;
    }

    public double Obsah()
    {
        return (Uhlu / 2) * Math.Pow(Delka, 2);
    }

    public int Obvod()
    {
        return Delka * Uhlu;
    }
}