
using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int Age { get; set; }

        public string? Phone { get; set; }

        public int ServiceSenterId { get; set; }
        public ServiceCenter? ServiceCenter { get; set; }

        public int DeliveryId { get; set; }
        public DeliveryPoint? DeliveryPoint { get; set; }
    }
}
