using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    public class Teacher:Person
    {
        public string Department { get; set; }
        public List<string> ClassesTaught { get; set; }

        public Teacher()
        {
            ClassesTaught = new List<string>();
        }
    }
}
