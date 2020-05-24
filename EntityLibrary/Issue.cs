using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Issue
    {
        public int ID { get; set; }
        public string IssueName { get; set; }
        public IssueType Type { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public Project Project { get; set; }
        public string Description { get; set; }

        public Issue()
        {

        }

        public Issue(string issueName, IssueType type, Priority priority, Complexity complexity,
            Project project,
            string description)
        {
            IssueName = issueName;
            Type = type;
            Priority = priority;
            Complexity = complexity;
            Project = project;
            Description = description;
        }

        public Issue(int id, string issueName, IssueType type, Priority priority, Complexity complexity,
            Project project,
            string description)
        {
            ID = id;
            IssueName = issueName;
            Type = type;
            Priority = priority;
            Complexity = complexity;
            Project = project;
            Description = description;
        }
    }
}
