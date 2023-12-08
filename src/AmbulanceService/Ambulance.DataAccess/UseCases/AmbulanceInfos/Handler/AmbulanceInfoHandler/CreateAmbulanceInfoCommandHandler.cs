using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Handler.AmbulanceInfoHandler
{
    public class CreateAmbulanceInfoCommandHandler : IRequestHandler<CreateAmbulanceInfoCommand,int>
    {
        private readonly IAmbulanceDbContext _context;
         
        public CreateAmbulanceInfoCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAmbulanceInfoCommand request, CancellationToken cancellationToken)
        {
            AmbulanceInfo ? ambulanceInfo = await _context.amulanceInfo.FirstOrDefaultAsync( cancellationToken);

            AmbulanceInfo info = new AmbulanceInfo() 
            {
                Model = request.Model,
                Available = request.Available
            };
            await _context.amulanceInfo.AddAsync(info, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
