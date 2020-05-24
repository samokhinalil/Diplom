using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class IssueHistory
    {
        public IssueHistory(int issueID, string issueName, string stateName, DateTime stateDate)
        {
            IssueID = issueID;
            IssueName = issueName;
            StateName = stateName;
            StateDate = stateDate;
        }

        public int IssueID { get; set; }
        public string IssueName { get; set; }
        public string StateName { get; set; }
        public DateTime StateDate { get; set; }


    }
}
