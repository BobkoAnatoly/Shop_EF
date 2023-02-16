using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public IQueryable<Product>? Products { get; set; }
    }
}
