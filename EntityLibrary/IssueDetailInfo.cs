using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class IssueDetailInfo
    {
        public IssueDetailInfo(int issueId,
            string issueName, 
            string priorityName,
            string complexityName, 
            string typeName, 
            string executorName, 
            string ownerName, 
            DateTime startDate, 
            DateTime endDate)
        {
            IssueId = issueId;
            IssueName = issueName;
            PriorityName = priorityName;
            ComplexityName = complexityName;
            TypeName = typeName;
            ExecutorName = executorName;
            OwnerName = ownerName;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int IssueId { get; set; }
        public string IssueName { get; set; }
        public string PriorityName { get; set; }
        public string ComplexityName { get; set; }
        public string TypeName { get; set; }
        public string ExecutorName { get; set; }
        public string OwnerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
