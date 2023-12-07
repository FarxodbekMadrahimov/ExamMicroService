using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Handler.AmbulanceInfoHandler
{
    public class DeleteAmbulanceInfoCommandHandler: IRequestHandler<DeleteAmbulanceInfoCommand,int>
    {
        private readonly IAmbulanceDbContext _context;
        public DeleteAmbulanceInfoCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteAmbulanceInfoCommand request, CancellationToken cancellationToken)
        {
            AmbulanceInfo? @class = await _context.amulanceInfo.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (@class == null)
                throw new Exception();

            _context.amulanceInfo.Remove(@class);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
