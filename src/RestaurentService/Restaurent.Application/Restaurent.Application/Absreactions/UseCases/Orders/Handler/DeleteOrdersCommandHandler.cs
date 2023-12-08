using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand;
using Restaurent.Application.Absreactions.UseCases.Orders.Commands;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.Orders.Handler
{
    public class DeletOrdersCommandHandler : IRequestHandler<DeleteOrdersCommand, int>
    {
        private readonly IRestaurentDbContext _context;
        public DeletOrdersCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteOrdersCommand request, CancellationToken cancellationToken)
        {
            Order? @class = await _context.orders.FirstOrDefaultAsync(x => x.OrderId == request.Id, cancellationToken);

            if (@class == null)
                throw new Exception();

            _context.orders.Remove(@class);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
