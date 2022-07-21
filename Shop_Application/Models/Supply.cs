using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class Supply
    {
        public int Id { get; set; }

        public DateTime SupplyDate { get; set; }

        public IQueryable<SupplyGoods>? Goods { get; set; }

        public Vendor? Vendor { get; set; }
        public int VendorId { get; set; }
    }
}
