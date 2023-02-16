using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop_Application.Interfaces;
using Shop_Application.Common.Exceptions;
using Shop_Application.Models;

namespace Shop_Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandHandler
        : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IShopDbContext context;

        public UpdateOrderCommandHandler(IShopDbContext dbContext) =>
            context = dbContext;

        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = await context.Orders
                .FirstOrDefaultAsync(o => o.Id == request.Id, cancellationToken);
            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }

            entity.OrderDate = DateTime.Now;
            entity.Product = request.Product;
            entity.DeliveryPoint = request.DeliveryPoint;
            entity.User = request.User;
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
