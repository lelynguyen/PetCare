namespace PetCareMVC.Models
{
    public class TypePet
    {
        public int TypePetId { get; set; }
        public string TypeName { get; set; }

        // Navigation properties
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
