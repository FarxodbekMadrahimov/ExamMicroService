using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries;
using Restaurent.Application.Absreactions.UseCases.Orders.Queries;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.Orders;

namespace Restaurent.Application.Absreactions.UseCases.Orders.Handler
{
    public class GetOrdersByIdCommandHandler : IRequestHandler<GetMORdersByIdQuery, Order>
    {
        private readonly IRestaurentDbContext _context;
        public GetOrdersByIdCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<Order> Handle(GetMORdersByIdQuery request, CancellationToken cancellationToken)
        {
            Order? ambulanceInfo = await _context.orders.FirstOrDefaultAsync(x => x.OrderId == request.Id, cancellationToken);

            if (ambulanceInfo == null)
                throw new Exception();

            return ambulanceInfo;
        }
    }
}
