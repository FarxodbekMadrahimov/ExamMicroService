using MediatR;
using Restaurent.Domain.Entities.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries
{
    public class GetMenuItemByIdQuery : IRequest<MenuItem>
    {
        public int Id { get; set; }
    }
}
