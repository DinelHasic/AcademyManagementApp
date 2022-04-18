using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement
{
    public class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        private string _password { get; set; }

        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            _password = password;
        }

        public string GetPassword()
        {
            return _password;
        }

        public override string ToString()
        {
            return $"Name:{Name} Surname:{Surname}";
        }
    }
}
