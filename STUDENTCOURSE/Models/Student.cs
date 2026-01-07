
namespace STUDENTCOURSE.Models
//this is a model
   
{
    public class Student
    {
        public int StudentId { get; set; }  
        public string? Name { get; set; }
        public string Email { get; set; } 
        public int Age { get; set; }   

        public ICollection<StudentCourse> StudentCourses { get; set; }
   
    }
}
