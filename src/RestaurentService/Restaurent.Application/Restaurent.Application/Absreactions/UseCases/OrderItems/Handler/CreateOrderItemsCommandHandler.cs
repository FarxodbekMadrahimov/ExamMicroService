using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand;
using Restaurent.Application.Absreactions.UseCases.OrderItems.Commands.OrderItemsCommand;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.OrderItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.OrderItems.Handler
{
    public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, int>
    {
        private readonly IRestaurentDbContext _context;

        public CreateOrderItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            OrderItem? ambulanceInfo = await _context.orderItems.FirstOrDefaultAsync(cancellationToken);
            OrderItem info = new OrderItem()
            {
                   MenuItemId = request.MenuItemId,
                   Quantity = request.Quantity,
                   OrderId = request.OrderId,
            };
            await _context.orderItems.AddAsync(info, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
