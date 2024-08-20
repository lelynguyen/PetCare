namespace PetCareMVC.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }

        // Navigation properties
        public virtual Account Account { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
