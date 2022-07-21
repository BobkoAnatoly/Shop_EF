using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class SupplyGoods
    {
        public int Id { get; set; }

        public int SupplyId { get; set; }  
        public Supply? Supply { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
