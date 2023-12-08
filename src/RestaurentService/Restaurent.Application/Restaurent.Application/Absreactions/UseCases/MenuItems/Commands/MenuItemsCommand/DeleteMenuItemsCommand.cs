using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand
{
    public class DeleteMenuItemCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
