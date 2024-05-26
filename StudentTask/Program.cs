using StudentTask;

public static class Program
{
    public static void Main()
    {
        Student student1 = new Student();
        Student student2 = new Student();
        student1.AddGrade("Oktay", new List<int> { 100, 95, 90 });
        student2.AddGrade("Nicat", new List<int> { 80, 90, 95 });
        student1.GetAverageGrade();
        student2.RemoveGrade("Nicat");
        student1.AddGrade("Oktay", new List<int> { 90, 100, 80 });
        student1.GetAverageGrade();
        student1.GetAllGradesByStudents("Oktay");
        student1.GetAllGradesByStudents("Nicat");
        Console.ReadLine();
    }
}