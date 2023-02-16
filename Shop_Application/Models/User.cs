using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        public IQueryable<Order>? Orders { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile? UserProfile{ get; set; }
        public Cart? Cart { get; set; }

    }
}
