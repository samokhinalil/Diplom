using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class TimeOutTasksInfoReport
    {
        public TimeOutTasksInfoReport(int taskID,
            string employeeFullName,
            DateTime requiredDate,
            string currentState,
            DateTime dateTimeStateDate,
            int dateDifference)
        {
            TaskID = taskID;
            EmployeeFullName = employeeFullName;
            RequiredDate = requiredDate;
            CurrentState = currentState;
            DateTimeStateDate = dateTimeStateDate;
            DateDifference = dateDifference;
        }

        public int TaskID { get; set; }
        public string EmployeeFullName { get; set; }
        public DateTime RequiredDate { get; set; }
        public string CurrentState { get; set; }
        public DateTime DateTimeStateDate { get; set; }
        public int DateDifference { get; set; }
}
}
