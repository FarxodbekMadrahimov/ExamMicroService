using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.OrderItems.Commands.OrderItemsCommand;
using Restaurent.Application.Absreactions.UseCases.Orders.Commands;
using Restaurent.Domain.Entities.OrderItems;
using Restaurent.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.OrderItems.Handler
{
    public class DeletOrderItemCommandHandler : IRequestHandler<DeleteOrderItemCommand, int>
    {
        private readonly IRestaurentDbContext _context;
        public DeletOrderItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
        {
            OrderItem? @class = await _context.orderItems.FirstOrDefaultAsync(x => x.OrderId == request.Id, cancellationToken);

            if (@class == null)
                throw new Exception();

            _context.orderItems.Remove(@class);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
