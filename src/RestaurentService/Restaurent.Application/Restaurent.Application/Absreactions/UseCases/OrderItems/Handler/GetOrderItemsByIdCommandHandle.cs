using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.OrderItems.Queries;
using Restaurent.Application.Absreactions.UseCases.Orders.Queries;
using Restaurent.Domain.Entities.OrderItems;
using Restaurent.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.OrderItems.Handler
{
    public class GetOrderItemByIdCommandHandler : IRequestHandler<GetOrderItemByIdQuery, OrderItem>
    {
        private readonly IRestaurentDbContext _context;
        public GetOrderItemByIdCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<OrderItem> Handle(GetOrderItemByIdQuery request, CancellationToken cancellationToken)
        {
            OrderItem? ambulanceInfo = await _context.orderItems.FirstOrDefaultAsync(x => x.OrderItemId == request.Id, cancellationToken);

            if (ambulanceInfo == null)
                throw new Exception();

            return ambulanceInfo;
        }
    }
}
