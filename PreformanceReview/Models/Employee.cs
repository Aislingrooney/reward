namespace PreformanceReview.Models
{
    public class Employee
    {
        public string EmployeeNumber { get; set; }
        public Enums.Title Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public Enums.Department Department { get; set; }
        public string JobRole { get; set; }
        public string Salary { get; set; }
    }
}