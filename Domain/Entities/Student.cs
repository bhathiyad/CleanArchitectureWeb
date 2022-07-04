using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public ICollection<StudentCourse> Courses { get; set; } = new Collection<StudentCourse>();
    }
}
