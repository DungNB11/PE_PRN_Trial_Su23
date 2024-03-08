﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
