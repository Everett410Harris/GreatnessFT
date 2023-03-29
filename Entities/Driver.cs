using System.ComponentModel.DataAnnotations;

namespace GreatnessFT.Entities
{
    public class Driver
    {
        
        [Key]
        public Guid DriversId { get; set; }
        public string DriversFirstName { get; set; }
        public string DriversLastName { get; set; }
        public DateOnly DriversDOB { get; set; }
        public string DriversGender { get; set; }
        public int DriversPhone { get; set; }
        public string DriversAddress { get; set; }
        public DateOnly DriversJoinDate { get; set; }

    }
}
