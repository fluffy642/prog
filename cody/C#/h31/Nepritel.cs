class Nepritel : Mistnost
{
    public Nepritel()
    {

    }
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Potkal jsi nepritele");
        int rnd = new Random().Next(1, 3);
        if (rnd == 1)
        {
            hrac.HP -= 20;
            Console.WriteLine("Prohral jsi souboj, -20 HP");
            if (hrac.HP <= 0)
            {
                hrac.Konec = true;
                Console.WriteLine("Zemrel jsi v souboji");
            }
        }
        else if (rnd == 2)
        {
            Console.WriteLine("Vyhral jsi souboj");
        }
    }
}