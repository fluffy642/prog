class Program
{
    static void Main()
    {
        // FizzBuzz
        /*Console.Write("Zadej cislo: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Buzz");
        } 
        else if (num % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(num);
        }*/


        // Nejblizsi mocnina 2
        /*Console.Write("Zadej cislo: ");
        int num = int.Parse(Console.ReadLine());

        int i = num;
        bool pokracovat = true;
        while (pokracovat)
        {
            for (int j = 1; j < num; j++)
            {
                if (Math.Pow(2, j) == i)
                {
                    Console.WriteLine(i);
                    pokracovat = false;
                }
            }
            i++;
        }*/

        // arr
        /*int[] arr = new int[10];
        int length = 0;
        int num;
        for (int i = 0;; i++)
        {
            Console.Write("Zadej cislo: ");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            arr[i] = num;
            length++;
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + ", ");
        }*/
    }
}