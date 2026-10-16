class Truhla : Mistnost
{
    public Truhla()
    {

    }
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Mas stesti");
        hrac.Penize += 10;
        Console.WriteLine("+ 10 penez");
    }
}