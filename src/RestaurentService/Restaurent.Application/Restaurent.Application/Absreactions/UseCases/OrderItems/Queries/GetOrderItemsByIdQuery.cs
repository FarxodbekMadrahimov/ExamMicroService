using MediatR;
using Restaurent.Domain.Entities.OrderItems;
using Restaurent.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.OrderItems.Queries
{
    public class GetOrderItemByIdQuery : IRequest<OrderItem>
    {
        public int Id { get; set; }
    }
}
