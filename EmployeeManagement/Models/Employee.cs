namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime DataOfBirth { get; set; }

        public int SocialSecurityNumber { get; set; }

        public Employee()
        {
            
        }
    }
}
