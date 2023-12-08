using MediatR;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.Orders.Queries
{
    public class GetMORdersByIdQuery : IRequest<Order>
    {
        public int Id { get; set; }
    }
}
