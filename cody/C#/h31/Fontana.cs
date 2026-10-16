class Fontana : Mistnost
{
    public Fontana()
    {

    }
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Potkal jsi lecivou fontanu");
        if (hrac.Penize >= 20)
        {
            hrac.HP += 20;
            hrac.Penize -= 20;
            Console.WriteLine("-20 penez, +20 HP");
        }
        else
        {
            Console.WriteLine("Nedostatek penez");
        }
    }
}