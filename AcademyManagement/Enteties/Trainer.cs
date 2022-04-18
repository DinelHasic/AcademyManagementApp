using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement
{
    public class Trainer : User
    {
        public Trainer(string name, string surname, string username, string password) : base(name, surname, username, password)
        {

        }
    }
}
