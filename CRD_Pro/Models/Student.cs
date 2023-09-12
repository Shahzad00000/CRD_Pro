using System;

namespace CRD_Pro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
        public DateTime Date {  get; set; }
        public bool IsActive { get; set; }
    }
    public enum Courses
    {
        BCA,ADCA,SSC,CCC,MCA
    }
    public enum Gender
    {
        Male,Female
    }
}
