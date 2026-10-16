class Hrac
{
    public int HP = 50;
    public int Penize = 0;
    public bool Konec = false;
    public Hrac()
    {

    }
    public void Hraj()
    {
        int rnd = new Random().Next(1, 11);

        if (Konec == true)
        {
            Console.WriteLine("\nHra je ukoncena, koncovy pocet penez - " + Penize);
            return;
        }

        if (rnd == 1 || rnd == 2 || rnd == 3)
        {
            new Fontana().Aktivuj(this);
        }
        else if (rnd == 4 || rnd == 5 || rnd == 6)
        {
            new Truhla().Aktivuj(this);
        }
        else if (rnd == 7 || rnd == 8 || rnd == 9)
        {
            new Nepritel().Aktivuj(this);
        } else if (rnd == 10)
        {
            new Trun().Aktivuj(this);
        }
        VypisInfo();

        Console.Write("\nJit dal? a/n : ");
        if (Console.ReadLine() == "n")
        {
            Konec = true;
            Hraj();
        }
        else
        {
            Hraj();
        }
    }
    public void VypisInfo()
    {
        Console.WriteLine("\nHP: " + HP);
        Console.WriteLine("Penez: " + Penize);
    }
}