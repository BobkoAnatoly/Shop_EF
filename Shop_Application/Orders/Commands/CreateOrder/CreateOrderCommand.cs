using MediatR;
using Shop_Application.Models;

namespace Shop_Application.Orders.Commands.Create
{
    public class CreateOrderCommand:IRequest<DateTime>
    {
        public DateTime OrderDate { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
        public DeliveryPoint? DeliveryPoint { get; set; }
    }
}
