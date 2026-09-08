class Program
{
    static void SmazaniHodnot(List<int> numbers, int num)
    {
        for (int i = numbers.Count; i > 0; i--)
        {
            if (numbers[i] == num)
            {
                numbers.RemoveAt(i);
            }
        }
    }
    static void Main()
    {
        /*char[] vajicka = { 'r', 'g', 'b' };

        List<char> vysluzka = new List<char>();

        bool pokracovat = true;
        int volba;
        char barva;

        while (pokracovat)
        {
            Console.WriteLine("\nMoznosti:");
            Console.WriteLine(" 1 = Pridej vajicka");
            Console.WriteLine(" 2 = Vypis sebrana vajicka");
            Console.WriteLine(" 3 = Vypis pocet vajicek");
            Console.WriteLine(" 0 = Ukoncit aplikaci");
            Console.Write("Vyber akci:");
            volba = int.Parse(Console.ReadLine());

            if (volba < 0 || volba > 3)
            {
                Console.WriteLine("Neplatna volba");
            }
            else if (volba == 1)
            {
                Console.Write("Zadej barvu vajicka (r/g/b):");
                barva = Console.ReadLine()[0];
                if (!vajicka.Contains(barva))
                {
                    Console.WriteLine("Neplatna barva");
                }
                else
                {
                    vysluzka.Add(barva);
                }
            }
            else if (volba == 2)
            {
                for (int i = 0; i < vysluzka.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. vajicko: {vysluzka[i]}");
                }
            }
            else if (volba == 3)
            {
                Console.WriteLine($"Pocet sebranych vajicek: {vysluzka.Count}");
            }
            else if (volba == 0)
            {
                Console.WriteLine("Konec");
                pokracovat = false;
            }
        }*/


        //    Smazani hodnoty z listu
        /*List<int> numbers = new List<int> {1, 2, 4, 5, 2, 4 };
        int num = 2;
        
        foreach (int value in numbers)
        {
            Console.Write(value + ", ");
        }
        SmazaniHodnot(numbers, num);
        foreach (int value in numbers)
        {
            Console.Write(value + ", ");
        }*/


        //    Databaze filmu
        List<string> films = new List<string> { "The Shawshank Redemption", "The Godfather", "The Dark Knight", "Pulp Fiction", "The Matrix" };
        List<double> scores = new List<double> { 9.3, 9.2, 9.1, 8.8, 8.7 };

        bool pokracovat = true;
        int volba;
        double score;
        double prumer;
        string name;
        string text;

        while (pokracovat)
        {
            Console.WriteLine("\nVyber moznost:");
            Console.WriteLine(" 1 = Pridat film");
            Console.WriteLine(" 2 = Vypsat vsechny filmy");
            Console.WriteLine(" 3 = Vypsat vsechny filmy s zadanym textem");
            Console.WriteLine(" 4 = Zjistit prumerne hodnoceni");
            Console.WriteLine(" 5 = Smazat film");
            Console.WriteLine(" 0 = Ukoncit program");
            Console.Write("Tvoje volba:");
            volba = int.Parse(Console.ReadLine());

            switch (volba)
            {
                case 0:
                    Console.WriteLine("\nKonec");
                    pokracovat = false;
                    break;
                case 1:
                    Console.Write("\nZadej nazev filmu: ");
                    name = Console.ReadLine();
                    films.Add(name);
                    Console.Write("Zadej hodnoceni filmu: ");
                    score = int.Parse(Console.ReadLine());
                    scores.Add(score);
                    break;
                case 2:
                    Console.Write("\n");
                    foreach (string value in films)
                    {
                        Console.WriteLine(value);
                    }
                    break;
                case 3:
                    Console.Write("\nZadej text: ");
                    text = Console.ReadLine();
                    foreach (string value in films)
                    {
                        if (value.Contains(text))
                        {
                            Console.WriteLine(value);
                        }
                    }
                    break;
                case 4:
                    prumer = 0;
                    foreach (double value in scores)
                    {
                        prumer += value;
                    }
                    Console.WriteLine("\nPrumerne hodnoceni: " + Math.Round(prumer / films.Count, 2));
                    break;
                case 5:
                    int index;
                    Console.Write("\nNapis nazev filmu na smazani: ");
                    name = Console.ReadLine();
                    for (int i = 0; i < films.Count; i++)
                    {
                        if (films[i].Contains(name))
                        {
                            index = i;
                            films.Remove(name);
                            scores.RemoveAt(i);
                            break;
                        }
                    }
                    break;
                default: 
                    Console.WriteLine("Neplatna volba");
                    break;
            }
        }
    }
}
        