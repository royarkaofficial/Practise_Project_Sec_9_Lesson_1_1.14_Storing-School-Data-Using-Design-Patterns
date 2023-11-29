﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    public class Student:Person
    {
        public int StudentId { get; set; }
        public List<string> Subjects { get; set; }

        public Student()
        {
            Subjects = new List<string>();
        }
    }
}
