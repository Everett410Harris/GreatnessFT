using System.ComponentModel.DataAnnotations;

namespace GreatnessFT.Entities
{
    public class Booking
    {
        
        [Key]
        public Guid BId { get; set; }
        public string BUser { get; set; }
        public string BCustFirstName { get; set; }
        public string BCustLastName { get; set; }
        public int BCustPhone { get; set; }
        public string BVehicle { get; set; }
        public string BDriver { get; set; }
        public DateOnly PickUpDate { get; set; }
        public DateOnly DropOffDate { get; set; }
    }
}
