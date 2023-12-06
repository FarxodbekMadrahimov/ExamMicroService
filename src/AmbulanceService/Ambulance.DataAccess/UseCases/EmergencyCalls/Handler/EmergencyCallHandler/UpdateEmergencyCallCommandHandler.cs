using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand;
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
    public class UpdateEmergencyCallCommandHandler : IRequestHandler<UpdateEmergencyCallCommand, int>
    {

        private readonly IAmbulanceDbContext _context;

        public UpdateEmergencyCallCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateEmergencyCallCommand request, CancellationToken cancellationToken)
        {
            EmergencyCalling? emergencyCalling = await _context.emergencyCalls.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (emergencyCalling == null)
            {
                throw new Exception();
            }
            emergencyCalling.CallerName = request.CallerName;
            emergencyCalling.Location = request.Location;
            emergencyCalling.AmbulanceDispatched = request.AmbulanceDispatched;
            emergencyCalling.AmbulanceId = request.AmbulanceId;

            _context.emergencyCalls.Add(emergencyCalling);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
