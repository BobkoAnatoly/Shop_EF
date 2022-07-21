using MediatR;
using Shop_Application.Models;

namespace Shop_Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand:IRequest
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
        public DeliveryPoint? DeliveryPoint { get; set; }
    }
}
