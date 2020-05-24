using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class ReportSimpleEntity
    {
        public ReportSimpleEntity(int value, string fieldName)
        {
            Value = value;
            FieldName = fieldName;
        }

        public int Value { get; set; }
        public string FieldName { get; set; }

    }
}
