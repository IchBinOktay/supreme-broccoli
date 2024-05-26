using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask
{
    internal class Student
    {
        Dictionary<string, List<int>> Grades = new();
        public void AddGrade(string name, List<int> myGrades)
        {
            foreach (var student in Grades)
            {
                if (name == student.Key)
                {
                    foreach (var List in Grades.Values)
                    {
                        foreach (var grade in myGrades)
                        {
                            List.Add(grade);
                        }
                    }
                }
                return;
            }
            Grades.Add(name, myGrades);
        }
        public void RemoveGrade(string name)
        {
            Grades.Remove(name);
        }
        public void GetAverageGrade()
        {
            int average = 0;
            int sum = 0;
            foreach (var List in Grades.Values)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    sum += List[i];
                }
                average = sum / List.Count;
            }
            Console.WriteLine(average);
        }

        public void GetAllGradesByStudents(string name)
        {


            foreach (var students in Grades)
            {
                if (name == students.Key)
                {
                    foreach (var List in Grades.Values)
                    {
                        for (int i = 0; i < List.Count; i++)
                        {
                            Console.Write(List[i] + " ");
                        }
                        Console.WriteLine(" ");
                        return;
                    }

                }

                Console.WriteLine($"Sorry,we do not have student called {name}");
            }
        }
    }
}
