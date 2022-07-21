using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop_Application.Interfaces;
using Shop_Application.Common.Exceptions;
using Shop_Application.Models;

namespace Shop_Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler
        : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IShopDbContext context;

        public DeleteOrderCommandHandler(IShopDbContext dbContext) =>
            context = dbContext;
        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = await context.Orders
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null || entity.User?.Id != request.Id)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
