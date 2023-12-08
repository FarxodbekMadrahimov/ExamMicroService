using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries;
using Restaurent.Application.Absreactions.UseCases.Orders.Queries;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.Orders.Handler
{
    public class GetOrdersCommandHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<Order>>
    {
        private readonly IRestaurentDbContext _context;

        public GetOrdersCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            List<Order> result = await _context.orders.ToListAsync(cancellationToken);
            if (result == null)
                throw new Exception();
            return result;
        }

    }
}
