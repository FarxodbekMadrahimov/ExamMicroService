using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions.UseCases.OrderItems.Commands.OrderItemsCommand;
using Restaurent.Application.Absreactions.UseCases.Orders.Commands;
using Restaurent.Domain.Entities.Orders;


namespace Restaurent.Application.Absreactions.UseCases.OrderItems.Handler
{
    public class UpdateOrderItemCommandHandler : IRequestHandler<UpdateOrderItemCommand, int>
    {
        private readonly IRestaurentDbContext _context;
        public UpdateOrderItemCommandHandler(IRestaurentDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.OrderItems.OrderItem? @ambulanceInfo = await _context.orderItems.FirstOrDefaultAsync(x => x.OrderItemId == request.OrderItemId, cancellationToken);
            if (@ambulanceInfo == null)
                throw new Exception();
            @ambulanceInfo.OrderItemId = request.OrderItemId;
            @ambulanceInfo.MenuItemId = request.MenuItemId;
            @ambulanceInfo.Quantity = request.Quantity;
            @ambulanceInfo.OrderId = request.OrderId;





            _context.orderItems.Update(@ambulanceInfo);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
