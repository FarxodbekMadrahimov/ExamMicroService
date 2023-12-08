using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand;
using Restaurent.Domain.Entities.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Application.Absreactions.UseCases.MenuItems.Handler.MenuItemsHandler
{
    public class DeletMenuItemsCommandHandler : IRequestHandler<DeleteMenuItemCommand, int>
    {
        private readonly IRestaurentDbContext _context;
        public DeletMenuItemsCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteMenuItemCommand request, CancellationToken cancellationToken)
        {
            MenuItem? @class = await _context.menuItems.FirstOrDefaultAsync(x => x.MenuItemId == request.Id, cancellationToken);

            if (@class == null)
                throw new Exception();

            _context.menuItems.Remove(@class);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}