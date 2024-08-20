namespace PetCareMVC.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int ServiceId { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }

        // Navigation properties
        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }
    }
}
