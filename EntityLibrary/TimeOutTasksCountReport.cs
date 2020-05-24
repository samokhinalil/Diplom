using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class TimeOutTasksCountReport
    {
        public TimeOutTasksCountReport(string employeeFullName, int timeOutTasksCount)
        {
            EmployeeFullName = employeeFullName;
            TimeOutTasksCount = timeOutTasksCount;
        }

        public string EmployeeFullName { get; set; }
        public int TimeOutTasksCount { get; set; }
    }
}
