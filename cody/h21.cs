using System.Net.Http.Headers;

class Program
{
    static bool Email(string str)
    {
        int res = 0;
        if (str[0] == '@')
        {
            return false;
        }
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '@')
            {
                for (int j = i; j < str.Length; j++)
                {
                    if (str[j] == '.')
                    {
                        res++;
                    }
                }
            }
        }
        return res > 0;
    }
    static void VelkeMale(string str, char pismeno)
    {
        int velke = 0;
        int male = 0;
        foreach (char znak in str)
        {
            if (znak == Char.ToUpper(pismeno))
            {
                velke++;
            } 
            else if (znak == Char.ToLower(pismeno))
            {
                male++;   
            }
        }
        if (velke > male)
        {
            Console.Write("velke");
        }
        else
        {
            Console.Write("male");
        }
        Console.WriteLine($" ({velke}*{Char.ToUpper(pismeno)}, {male}*{Char.ToLower(pismeno)})");
    }
    static void Main()
    {
        //overeni emailu
        //Console.WriteLine(Email("email@.cz"));

        //velkych nebo malych pismen
        VelkeMale("CIA ma znamku AAA aaaa", 'a');

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

    }
}