using System.ComponentModel.DataAnnotations;

namespace GreatnessFT.Entities
{
    public class User
    {
        
        [Key]
        public Guid UsersId { get; set; }
        public string UsersFirstName { get; set; }
        public string UsersLastName { get; set; }
        public DateOnly UsersDOB { get; set; }
        public string UsersGender { get; set; }
        public int UsersPhone { get; set; }
        public string UsersAddress { get; set; }
        public string UsersPassword { get; set; }
        public DateOnly UsersJoinDate { get; set; }

    }
}
