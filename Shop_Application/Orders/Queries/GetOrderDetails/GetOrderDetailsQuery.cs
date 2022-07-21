using MediatR;
namespace Shop_Application.Orders.Queries.GetOrderDetails
{
    public class GetOrderDetailsQuery : IRequest<OrderDetailVm>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
