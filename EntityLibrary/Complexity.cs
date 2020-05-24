using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Complexity
    {
        public int ID { get; set; }
        public string ComplexityName { get; set; }
        public int ComplexityValue { get; set; }

        public Complexity()
        {
        }

        public Complexity(string name, int value)
        {
            ComplexityName = name;
            ComplexityValue = value;
        }

        public Complexity(int id, string name, int value)
        {
            ID = id;
            ComplexityName = name;
            ComplexityValue = value;
        }
    }
}
