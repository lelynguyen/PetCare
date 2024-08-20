namespace PetCareMVC.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public int CustomerId { get; set; }
        public int TypePetId { get; set; }
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }

        // Navigation properties
        public virtual Customer Customer { get; set; }
        public virtual TypePet TypePet { get; set; }

        // Thêm các thuộc tính điều hướng sau:
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
