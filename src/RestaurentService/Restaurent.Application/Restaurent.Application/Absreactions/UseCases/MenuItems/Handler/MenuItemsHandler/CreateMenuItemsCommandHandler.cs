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
    public class CreateMenuItemCommandHandler : IRequestHandler<CreateMenuItemCommand, int>
    {
        private readonly IRestaurentDbContext _context;

        public CreateMenuItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateMenuItemCommand request, CancellationToken cancellationToken)
        {
            MenuItem? ambulanceInfo = await _context.menuItems.FirstOrDefaultAsync(cancellationToken);
            if (ambulanceInfo == null)
            {
                throw new Exception();
            }
            MenuItem info = new MenuItem()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
            };
            await _context.menuItems.AddAsync(info, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
