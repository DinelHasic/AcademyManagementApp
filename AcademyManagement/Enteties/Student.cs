using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement
{
    public class Student:User
    {
        public Subject Subject { get; set; }

        public Student(string name,string surname,string username,string password,Subject subject):base(name,surname,username,password)
        {
            Subject = subject;
        }
    }
}
