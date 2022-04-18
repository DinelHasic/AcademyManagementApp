using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement
{
    public class Admin : User
    {
        public Admin(string name, string surname, string username, string password) : base(name, surname, username, password)
        {
        }

        public void AddUser(List<User> users,User user)
        {
            
        }

        public void RemoveUser(List<User> users, User user)
        {

        }
    }
}
