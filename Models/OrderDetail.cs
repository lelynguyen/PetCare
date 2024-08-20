namespace PetCareMVC.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int PetId { get; set; }
        public int ServiceId { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual Service Service { get; set; }

    }
}
