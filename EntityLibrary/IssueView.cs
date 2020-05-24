using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class IssueView
    {
        public int ID { get; set; }
        public string IssueName { get; set; }
        public int PriorityID { get; set; }
        public int ComplexityID { get; set; }
        public int TypeID { get; set; }
        public int ProjectID { get; set; }
        public State CurrentState { get; set; }
        public string Description { get; set; }
        public List<IssueView> SubIssues { get; set; }

        public IssueView()
        {
            CurrentState = new State();
        }

        public IssueView(string issueName, int priotityID, int complexityID,
            int typeID, int projectID, string description,
            int currentStateID, string stateName)
        {
            IssueName = issueName;
            PriorityID = priotityID;
            ComplexityID = complexityID;
            TypeID = typeID;
            ProjectID = projectID;
            Description = description;
            CurrentState = new State(currentStateID, stateName);
        }

        public IssueView(int id, string issueName, int priotityID, int complexityID,
            int typeID, int projectID, string description,
            int currentStateID, string stateName)
        {
            ID = id;
            IssueName = issueName;
            PriorityID = priotityID;
            ComplexityID = complexityID;
            TypeID = typeID;
            ProjectID = projectID;
            Description = description;
            CurrentState = new State(currentStateID, stateName);
        }
    }
}
