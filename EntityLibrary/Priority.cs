using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Priority
    {
        public int ID { get; set; }
        public string PriorityName { get; set; }
        public int PriorityValue { get; set; }

        public Priority()
        {
        }

        public Priority(string name, int value)
        {
            PriorityName = name;
            PriorityValue = value;
        }

        public Priority(int id, string name, int value)
        {
            ID = id;
            PriorityName = name;
            PriorityValue = value;
        }
    }
}
