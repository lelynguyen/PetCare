namespace PetCareMVC.Models
{
    public class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public int PetId { get; set; }
        public int ServiceId { get; set; }

        // Navigation properties
        public virtual Invoice Invoice { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual Service Service { get; set; }
    }
}
