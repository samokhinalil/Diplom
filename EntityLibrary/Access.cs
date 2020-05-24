using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Access
    {
        private string _password;
        public Employee Employee { get; set; }
        public string Login { get; set; }
        public string Password
        {
            set
            {
                _password = SHA1Hasher.GetHash(value);
            }
            get
            {
                return _password;
            }
        }
        public Role Role { get; set; }

        public Access()
        {
            Employee = new Employee();
            Role = new Role();
        }

        public Access(Employee employee, string login, string password, Role role)
        {
            Employee = employee;
            Login = login;
            Password = password;
            Role = role;
        }
    }
}
