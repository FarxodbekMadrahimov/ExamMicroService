using MediatR;
using Restaurent.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.OrderItems.Commands.OrderItemsCommand
{
    public class UpdateOrderItemCommand : UpdateItemDto, IRequest<int>
    {

    }
}
