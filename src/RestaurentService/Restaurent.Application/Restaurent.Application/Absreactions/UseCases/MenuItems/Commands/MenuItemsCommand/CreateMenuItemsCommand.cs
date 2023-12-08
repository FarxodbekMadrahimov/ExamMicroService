using MediatR;
using Restaurent.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand
{
    public class CreateMenuItemCommand : CreateMenuItemDto, IRequest<int>
    {
    }
}
