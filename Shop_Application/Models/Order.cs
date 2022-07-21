namespace Shop_Application.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
        public DeliveryPoint? DeliveryPoint { get; set; }

    }

}