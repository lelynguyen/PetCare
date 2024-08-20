using Microsoft.Extensions.Hosting;

namespace PetCareMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }

        // Navigation properties
        public virtual Role Role { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
