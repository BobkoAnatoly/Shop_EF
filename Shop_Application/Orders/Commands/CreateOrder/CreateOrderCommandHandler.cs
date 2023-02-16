using MediatR;
using Shop_Application.Interfaces;
using Shop_Application.Models;

namespace Shop_Application.Orders.Commands.Create
{
    public class CreateOrderCommandHandler
        : IRequestHandler<CreateOrderCommand,DateTime>
    {
        private readonly IShopDbContext context;
        public CreateOrderCommandHandler(IShopDbContext dbContext) =>
            context = dbContext;

        public async Task<DateTime> Handle(CreateOrderCommand request,
            CancellationToken cancellationToken)
        {
            var order = new Order
            {
                OrderDate = DateTime.Now,
                Product = request.Product,
                DeliveryPoint = request.DeliveryPoint,
                User = request.User
            };
            await context.Orders.AddAsync(order,cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return order.OrderDate;
        }

    }
}
