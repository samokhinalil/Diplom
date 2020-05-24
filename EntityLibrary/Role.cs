using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }

        public Role()
        {
        }

        public Role(string name)
        {
            RoleName = name;
        }

        public Role(int id, string name)
        {
            ID = id;
            RoleName = name;
        }
    }
}
