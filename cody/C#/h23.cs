using System;

class Program
{
    static void BubbleSorting(int[] arr)
    {
        int num;
        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    num = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = num;
                }
            }
        }
        
    }

    static List<int> SelectionSorting(List<int> arr)
    {
        List<int> copy = new List<int>();
        int min;
        int length = arr.Count;
        
        for (int i = 0; i < length; i++)
        {
            min = arr.Min();
            copy.Add(min);
            arr.Remove(min);
        }
        return copy;   
    }
    static void Main()
    {
        List<int> list1 = new List<int> { 4, 2, 3, 8, 1, 2 };
        int[] num1 = { 4, 2, 3, 8, 1, 2 };
        List<int> list2 = new List<int>();
        int[] num2;

        
        foreach (int item in num1)
        {
            Console.Write(" " + item);   
        }
        Console.WriteLine("\n");
        BubbleSorting(num1);
        foreach (int item in num1)
        {
            Console.Write(" " + item);
        }


    }
}
