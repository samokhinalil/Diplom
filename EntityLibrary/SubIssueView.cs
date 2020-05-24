using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class SubIssueView
    {
        public SubIssueView(int iD, string subIssueName, State subIssueCurrentState)
        {
            ID = iD;
            SubIssueName = subIssueName;
            SubIssueCurrentState = subIssueCurrentState;
        }

        public int ID { get; set; }
        public string SubIssueName { get; set; }
        public State SubIssueCurrentState { get; set; }
    }
}
