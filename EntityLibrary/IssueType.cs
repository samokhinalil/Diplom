using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class IssueType
    {
        public int ID { get; set; }
        public string TypeName { get; set; }

        public IssueType()
        {
        }

        public IssueType(string name)
        {
            TypeName = name;
        }

        public IssueType(int id, string name)
        {
            ID = id;
            TypeName = name;
        }
    }
}
