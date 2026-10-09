public class Hrac
{
    public string Jmeno {  get; set; }
    public Hrac(string jmeno)
    {
        Jmeno = jmeno;
    }

    public void Utok()
    {
        Console.WriteLine($"{Jmeno} utoci.");
    }
    public void Utok(int sila)
    {
        Console.WriteLine($"{Jmeno} utoci silou {sila}.");
    }
    public void Utok(string zbran)
    {
        Console.WriteLine($"{Jmeno} utoci pomoci {zbran}.");
    }
    public void Utok(int sila, string zbran)
    {
        Console.WriteLine($"{Jmeno} utoci pomoci {zbran} silou {sila}.");
    }

}