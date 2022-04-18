using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement
{
    public class Subject
    {
        public string Name;

        public List<int> Grades;

        public Subject(string sub, List<int> grades)
        {
            Name = sub;
            Grades = grades;
        }

        public void PrintGrades()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
