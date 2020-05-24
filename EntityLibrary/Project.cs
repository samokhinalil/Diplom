using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }

        public Project()
        {
        }

        public Project(string projectName, DateTime startDate)
        {
            ProjectName = projectName;
            this.StartDate = startDate;
        }

        public Project(int iD, string projectName, DateTime startDate)
        {
            ID = iD;
            ProjectName = projectName;
            this.StartDate = startDate;
        }
    }
}
