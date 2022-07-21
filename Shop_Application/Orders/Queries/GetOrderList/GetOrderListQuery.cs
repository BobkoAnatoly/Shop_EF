using MediatR;
namespace Shop_Application.Orders.Queries.GetOrderList
{
    public class GetOrderListQuery:IRequest<OrderListVm>
    {
        public int UserId { get; set; }
    }
}
