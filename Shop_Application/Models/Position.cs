
using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }

    }
}
