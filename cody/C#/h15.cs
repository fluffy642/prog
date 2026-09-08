class Program
{
    static void Main()
    {
        // vyplata
        /*Console.Write("Zadej pocet prednasek: ");
        int prednasky = int.Parse(Console.ReadLine());
        Console.Write("Zadej pocet seminaru: ");
        int seminare = int.Parse(Console.ReadLine());
        Console.Write("Zadej hodinovou mzdu: ");
        int mzda = int.Parse(Console.ReadLine());

        int res = (prednasky * 2 + seminare) * mzda;
        Console.WriteLine("Vyplata: " + res);*/


        // nohy kurat
        /*Console.Write("Zadej pocet nohou zvirat: ");
        int nohy = int.Parse(Console.ReadLine());
        Console.Write("Zadej pocet prasat: ");
        int prasa = int.Parse(Console.ReadLine());

        int kure = (nohy - prasa * 4) / 2;
        Console.WriteLine("Pocet kurat: " + kure);*/


        // hlasy
        /*Console.Write("Zadej pocet hlasu x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Zadej pocet hlasu y: ");
        int y = int.Parse(Console.ReadLine());

        int celkem = x + y;
        Console.WriteLine("Procenta hlasu x: " + x * 100 / celkem + " %");
        Console.WriteLine("Procenta hlasu y: " + y * 100 / celkem + " %");*/


        // sachovnice
        /*Console.Write("Zadej 1. znak: ");
        char x = char.Parse(Console.ReadLine());
        Console.Write("Zadej 2. znak: ");
        char y = char.Parse(Console.ReadLine());
        Console.Write("Zadej vysku sachovnice: ");
        int vyska = int.Parse(Console.ReadLine());
        Console.Write("Zadej sirku sachovnice: ");
        int sirka = int.Parse(Console.ReadLine());

        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < sirka; j++)
            {
                if (i % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(y);
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(y);
                    }
                    else
                    {
                        Console.Write(x);
                    }
                }
            }
            
            Console.WriteLine("\n");
        }*/

        // kalkulacka
        Console.Write("Zadej 1. operand: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Zadej 2. operand: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Zadej operaci: ");
        char znak = char.Parse(Console.ReadLine());

        int res;
        switch (znak) 
        {
            case '+':
                res = x + y;
                break;
            case '-':
                res = x - y;
                break;
            case '*':
                res = x * y;
                break;
            case '/':
                res = x / y;
                break;
            default:
                break;
        }
        Console.WriteLine("Vysledek: " + res);
    }
}