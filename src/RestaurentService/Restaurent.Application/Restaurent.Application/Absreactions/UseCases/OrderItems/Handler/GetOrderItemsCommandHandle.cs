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
    public class GetOrderItemCommandHandler : IRequestHandler<GetAllOrderItemQuery, IEnumerable<OrderItem>>
    {
        private readonly IRestaurentDbContext _context;

        public GetOrderItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderItem>> Handle(GetAllOrderItemQuery request, CancellationToken cancellationToken)
        {
            List<OrderItem> result = await _context.orderItems.ToListAsync(cancellationToken);
            if (result == null)
                throw new Exception();
            return result;
        }

    }
}
