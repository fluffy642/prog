class Program
{
    static bool Serazene(int[] arr)
    {
        int length = arr.Length;
        int[] arr2 = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr2[i] = arr[i];
        }
        Array.Sort(arr2);
        for (int i = 0; i < length; i++)
        {
            if (arr2[i] != arr[i])
            {
                return false;
            }
        }
        return true;
    }

    static bool StejnePrvky(int[] arr)
    {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    res++;
                }
            }
            if (res > 1)
            {
                return true;
            }
            res = 0;
        }
        return false;
    }

    static bool Prvocislo(int[] arr) 
    {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (true)
                {
                    
                }
            }
        }
    }
    static void Main()
    {
        /*double[] arr = new double[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Maximum: {arr.Max()}");
        Console.WriteLine($"Rozdil mezi min a max: {arr.Max() - arr.Min()}");
        Array.Sort(arr);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1}. nejnizsi hodnota: {arr[i]}");
        }
        foreach (double value in arr)
        {
            Console.Write($"{value}, ");
        }
        double median = (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
        Console.WriteLine($"Median: {median}");*/

        int[] arr = {1, 4, 9, 9};
        Console.WriteLine(Serazene(arr));
        Console.WriteLine(StejnePrvky(arr));



    }
}
