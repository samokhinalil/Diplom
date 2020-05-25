using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class CoefficientCalculatorDao
    {
        private List<Employee> employeeList;
        private List<AppropriateEmployee> result = new List<AppropriateEmployee>();

        public CoefficientCalculatorDao(List<Employee> employees)
        {
            this.employeeList = employees;
        }

        public List<AppropriateEmployee> GetEmployeesWithCoefficient()
        {
            Random r = new Random();
            double coefficient = 0;
            foreach (var employee in employeeList)
            {
                coefficient = r.NextDouble();
                result.Add(new AppropriateEmployee(employee, coefficient));
            }
            return result;
        }
    }
}
