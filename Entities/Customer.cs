using System.ComponentModel.DataAnnotations;

namespace GreatnessFT.Entities
{
    public class Customer
    {
        
        [Key]
        public Guid CustId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public int CustPhone { get; set; }
        public string CustAddress { get; set; }
        public string CustEmail { get; set; }
        public DateOnly CustJoinDate { get; set; }
    }
}
