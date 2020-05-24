using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class IssueListView
    {
        public int ID { get; set; }
        public string IssueName { get; set; }
        public string PriorityName { get; set; }
        public string ComplexityName { get; set; }
        public string TypeName { get; set; }
        public string CurrentStateName { get; set; }

        public IssueListView(int id, string issueName, string priorityName,
            string complexityName, string typeName, string currentState)
        {
            ID = id;
            IssueName = issueName;
            PriorityName = priorityName;
            ComplexityName = complexityName;
            TypeName = typeName;
            CurrentStateName = currentState;
        }

        
    }
}
