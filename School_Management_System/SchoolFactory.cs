using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School_Management_System
{
    public class SchoolFactory
    {
        public static Student CreateStudent(string name, string classAndSection)
        {
            return new Student { Name = name, ClassAndSection = classAndSection };
        }

        public static Teacher CreateTeacher(string name, string classAndSection)
        {
            return new Teacher { Name = name, ClassAndSection = classAndSection };
        }

        public static Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher };
        }
    }
}
