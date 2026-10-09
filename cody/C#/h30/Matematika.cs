public class Matematika
{
    public Matematika()
    {

    }

    /*public void Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            Console.WriteLine(num1);
            return;
        }
        Console.WriteLine(num2);
    }*/
    /*public void Max(int num1, int num2, int num3)
    {
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }*/
    public void Max(int num1, int num2)
    {
        Console.WriteLine((new int[] { num1, num2}).Max());
    }
    public void Max(int num1, int num2, int num3)
    {
        Console.WriteLine((new int[] { num1, num2, num3 }).Max());
    }
    public void Max(int[] numbers)
    {
        Console.WriteLine(numbers.Max());
    }

}