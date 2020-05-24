using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; } = new Position();

        public Employee()
        {
        }

        public Employee(string fullName, string passport, string phone, string email, Position position)
        {
            FullName = fullName;
            Passport = passport;
            Phone = phone;
            Email = email;
            Position = position;
        }

        public Employee(int id, string fullName, string passport, string phone, string email, Position position)
        {
            ID = id;
            FullName = fullName;
            Passport = passport;
            Phone = phone;
            Email = email;
            Position = position;
        }
    }
}
