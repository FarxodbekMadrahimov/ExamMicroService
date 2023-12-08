using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries;
using Restaurent.Domain.Entities.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.MenuItems.Handler.MenuItemsHandler
{
    public class GetMenuItemCommandHandler : IRequestHandler<GetAllMenuItemQuery, IEnumerable<MenuItem>>
    {
        private readonly IRestaurentDbContext _context;

        public GetMenuItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MenuItem>> Handle(GetAllMenuItemQuery request, CancellationToken cancellationToken)
        {
            List<MenuItem> result = await _context.menuItems.ToListAsync(cancellationToken);
            if (result == null)
                throw new Exception();
            return result;
        }
    }
}
