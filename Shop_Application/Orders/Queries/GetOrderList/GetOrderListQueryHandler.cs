using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop_Application.Interfaces;

namespace Shop_Application.Orders.Queries.GetOrderList
{
    public class GetOrderListQueryHandler : IRequestHandler<GetOrderListQuery, OrderListVm>
    {
        private readonly IShopDbContext context;
        private readonly IMapper _mapper;
        public GetOrderListQueryHandler(IShopDbContext dbContext, IMapper mapper) =>
            (context, _mapper) = (dbContext, mapper);
        public async Task<OrderListVm> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            var ordersQuery = await context.Orders
                .Where(order => order.User!.Id == request.UserId)
                .ProjectTo<OrderLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new OrderListVm { Orders = ordersQuery };
        }
    }
}
