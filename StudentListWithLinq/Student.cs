using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentListWithLinq
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Score { get; set; }
        public bool IsActive { get; set; }
        public string City { get; set; }

    }
    public class MinimalStudent
    {
        public string StudentName { get; set; }
        public int Score { get; set; }
    }
}