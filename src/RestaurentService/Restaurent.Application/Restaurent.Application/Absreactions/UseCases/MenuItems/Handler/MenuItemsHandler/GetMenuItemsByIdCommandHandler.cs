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
    public class GetMenuItemByIdCommandHandler : IRequestHandler<GetMenuItemByIdQuery, MenuItem>
    {
        private readonly IRestaurentDbContext _context;
        public GetMenuItemByIdCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<MenuItem> Handle(GetMenuItemByIdQuery request, CancellationToken cancellationToken)
        {
            MenuItem? ambulanceInfo = await _context.menuItems.FirstOrDefaultAsync(x => x.MenuItemId == request.Id, cancellationToken);

            if (ambulanceInfo == null)
                throw new Exception();

            return ambulanceInfo;
        }
    }
}
