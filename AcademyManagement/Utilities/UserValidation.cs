using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Utilities
{
    public static class UserValidation
    {

        public static void ValidInput(this string username)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Input is invalid");
            }
        }
    }
}
