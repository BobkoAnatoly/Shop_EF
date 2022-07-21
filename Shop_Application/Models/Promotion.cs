using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public IQueryable<Product>? Products { get; set; }
   }
}
