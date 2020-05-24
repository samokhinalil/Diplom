using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class StateEmployeeTasksCountReport
    {
        public StateEmployeeTasksCountReport(string stateName, int tasksCount)
        {
            StateName = stateName;
            TasksCount = tasksCount;
        }

        public string StateName { get; set; }
        public int TasksCount { get; set; }
    }
}
