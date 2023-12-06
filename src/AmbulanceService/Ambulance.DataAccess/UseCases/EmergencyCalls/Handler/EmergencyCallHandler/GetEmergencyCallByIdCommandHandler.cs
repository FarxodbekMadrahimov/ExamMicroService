using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.EmergencyCalls.Queries.EmergencyCallQueries;
using Ambulance.Domain.Entitites.EmergencyCalls;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.EmergencyCalls.Handler.EmergencyCallHandler
{
    public class GetEmergencyCallByIdCommandHandler : IRequestHandler<GetemergencyCallByIdQuery, EmergencyCalling>
    {
        private readonly IAmbulanceDbContext _context;
        public GetEmergencyCallByIdCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<EmergencyCalling> Handle(GetemergencyCallByIdQuery request, CancellationToken cancellationToken)
        {
            EmergencyCalling? emergencyCalling = await _context.emergencyCalls.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (emergencyCalling == null)
                throw new Exception();
            return emergencyCalling;
        }
    }

}
