using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Todo
    {
        public Todo(int iD, string name, bool done)
        {
            ID = iD;
            Name = name;
            Done = done;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }

        public bool IsValid()
        {
            if(ID <= 0)
                return false;
            if(Name == null) 
                return false;
            return true;
        }
    }
}
