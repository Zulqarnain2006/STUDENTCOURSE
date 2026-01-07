using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace STUDENTCOURSE.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }  
        public string? Name { get; set; }
        public string? Subject { get; set; } 
        public ICollection<Course> Courses { get; set; }

    }
}
