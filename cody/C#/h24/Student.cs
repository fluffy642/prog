public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
    public List<int> Marks;

    public Student(string jmeno, int vek, string trida)
    {
        Name = jmeno;
        Age = vek;
        Class = trida;
        Marks = new List<int>();
    }

    public void AddMark(int znamka)
    {
        Marks.Add(znamka);
    }
    public void RemoveMark(int znamka)
    {
        Marks.Remove(znamka);
    }
    public void ShowInfo()
    {
        Console.WriteLine("Jmeno studenta: " + Name);
        Console.WriteLine("Vek studenta: " + Age);
        Console.WriteLine("Trida studenta: " + Class);
        Console.Write("Znamky studenta: ");
        foreach (int znamka in Marks)
        {
            Console.Write(znamka + " ");
        }
        Console.WriteLine("\n");
    }
    public void ChangeClass(string trida)
    {
        Class = trida;
    }
    public double AverageMarks()
    {
        double res = 0;
        foreach (int znamka in Marks)
        {
            res += znamka;
        }
        return res / Marks.Count;
    }
    public bool IfAdult()
    {
        return Age >= 18;
    }
}