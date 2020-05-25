using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class AppropriateEmployee
    {
        public AppropriateEmployee(Employee employee, double coefficient)
        {
            this.employee = employee;
            ID = employee.ID;
            FullName = employee.FullName;
            Position = employee.Position.PositionName;
            Coefficient = coefficient;
        }

        private Employee employee;
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Coefficient { get; set; }
    }
}
