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
    public class UpdateMenuItemCommandHandler : IRequestHandler<UpdateMenuItemCommand, int>
    {
        private readonly IRestaurentDbContext _context;
        public UpdateMenuItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateMenuItemCommand request, CancellationToken cancellationToken)
        {
            MenuItem? @ambulanceInfo = await _context.menuItems.FirstOrDefaultAsync(x => x.MenuItemId == request.MenuItemId, cancellationToken);
            if (@ambulanceInfo == null)
                throw new Exception();

            @ambulanceInfo.MenuItemId = request.MenuItemId;
            @ambulanceInfo.Name = request.Name;
            @ambulanceInfo.Description = request.Description;
            ambulanceInfo.Price = request.Price;


            _context.menuItems.Update(@ambulanceInfo);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
