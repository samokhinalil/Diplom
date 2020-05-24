using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Position
    {
        public int ID { get; set; }
        public string PositionName { get; set; }

        public Position()
        {
        }

        public Position(string name)
        {
            PositionName = name;
        }

        public Position(int id, string name)
        {
            ID = id;
            PositionName = name;
        }

        public override string ToString()
        {
            return PositionName;
        }
    }
}
