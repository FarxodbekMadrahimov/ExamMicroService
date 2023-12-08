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
    public class CreateOrdersCommandHandler : IRequestHandler<CreateOrdersCommand, int>
    {
        private readonly IRestaurentDbContext _context;

        public CreateOrdersCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrdersCommand request, CancellationToken cancellationToken)
        {
            Order? ambulanceInfo = await _context.orders.FirstOrDefaultAsync(cancellationToken);
  
            Order info = new Order()
            {
                Date = request.Date,
                TotalAmount = request.TotalAmount,

            };
            await _context.orders.AddAsync(info, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
