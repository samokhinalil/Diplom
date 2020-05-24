using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class ActiveEmployeeIssue
    {
        public ActiveEmployeeIssue(int issueID, Priority issuePriority, DateTime endDate)
        {
            IssueID = issueID;
            IssuePriority = issuePriority;
            EndDate = endDate;
        }

        public int IssueID { get; set; }
        public Priority IssuePriority { get; set; }
        public DateTime EndDate { get; set; }
    }
}
