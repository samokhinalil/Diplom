using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class SolvedTasksComplexityReport
    {
        public SolvedTasksComplexityReport(string complexity, int count)
        {
            Complexity = complexity;
            Count = count;
        }

        public string Complexity { get; set; }
        public int Count { get; set; }
    }
}
