
namespace Shop_Application.Models
{
    public class Vendor
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public string Phone { get; set; }

        public IQueryable<Supply>? Supplies { get; set; }

    }
}
