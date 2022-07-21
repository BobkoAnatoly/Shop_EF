using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string? Phone { get; set; }

        public User? User { get; set; }
    }
}
