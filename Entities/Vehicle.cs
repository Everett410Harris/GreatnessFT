using System.ComponentModel.DataAnnotations;

namespace GreatnessFT.Entities
{
    public class Vehicle
    {
        
        [Key]
        public Guid VId { get; set; }
        public string VLicensePlate { get; set; }
        public string VModel { get; set; }
        public int VYear { get; set; }
        public string VEngType { get; set; }
        public string VColor { get; set; }
        public int VMileage { get; set; }
        public string VMake { get; set; }
        public string VType { get; set; }
        public string VBooked { get; set; }

    }



    

}
