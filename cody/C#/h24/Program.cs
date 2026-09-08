class Program
{
    static void Main()
    {
        Student student2 = new Student("Roman", 16, "IT3A");
        student2.AddMark(5);
        student2.AddMark(1);
        student2.ShowInfo();
        student2.RemoveMark(5);
        student2.ShowInfo();
        student2.AddMark(5);
        student2.AddMark(3);
        student2.AddMark(1);
        Console.WriteLine(student2.AverageMarks());
        student2.ShowInfo();
        Console.WriteLine(student2.IfAdult());
    }
}