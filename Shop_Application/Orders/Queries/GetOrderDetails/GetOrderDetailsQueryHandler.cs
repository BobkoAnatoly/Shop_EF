using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop_Application.Common.Exceptions;
using Shop_Application.Interfaces;
using Shop_Application.Models;

namespace Shop_Application.Orders.Queries.GetOrderDetails
{
    public class GetOrderDetailsQueryHandler
        : IRequestHandler<GetOrderDetailsQuery, OrderDetailVm>
    {
        private readonly IShopDbContext context;
        private readonly IMapper _mapper;
        public GetOrderDetailsQueryHandler(IShopDbContext dbContext, IMapper mapper) =>
            (context, _mapper) = (dbContext, mapper);

        public async Task<OrderDetailVm> Handle(GetOrderDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await context.Orders
                .FirstOrDefaultAsync(order =>
                order.Id == request.Id, cancellationToken);

            if (entity == null ||entity.User?.Id != request.UserId)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }
            return _mapper.Map<OrderDetailVm>(entity);
        }
    }
}
