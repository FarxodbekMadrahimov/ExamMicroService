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
    public class UpdateOrdersCommandHandler : IRequestHandler<UpdateOrdersCommand, int>
    {
        private readonly IRestaurentDbContext _context;
        public UpdateOrdersCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateOrdersCommand request, CancellationToken cancellationToken)
        {
            Order? @ambulanceInfo = await _context.orders.FirstOrDefaultAsync(x => x.OrderId == request.OrderId, cancellationToken);
            if (@ambulanceInfo == null)
                throw new Exception();
            @ambulanceInfo.OrderId = request.OrderId;
            @ambulanceInfo.Date = DateTime.Now;
            @ambulanceInfo.TotalAmount = request.TotalAmount;



            _context.orders.Update(@ambulanceInfo);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
