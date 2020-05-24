using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class State
    {
        public int ID { get; set; }
        public string StateName { get; set; }

        public State()
        {
        }

        public State(string name)
        {
            StateName = name;
        }

        public State(int id, string name)
        {
            ID = id;
            StateName = name;
        }

        public override string ToString()
        {
            return StateName;
        }
    }
}
