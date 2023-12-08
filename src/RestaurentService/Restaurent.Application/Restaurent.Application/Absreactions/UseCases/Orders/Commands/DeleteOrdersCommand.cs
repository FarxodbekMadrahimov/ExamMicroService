using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.Orders.Commands
{
    public class DeleteOrdersCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
