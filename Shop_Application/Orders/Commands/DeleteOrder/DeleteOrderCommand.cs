using MediatR;

namespace Shop_Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
