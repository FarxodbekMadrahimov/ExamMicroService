using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.EmergencyCalls.Handler.EmergencyCallHandler
{
    public class DeleteEmergencyCallCommandHandler : IRequestHandler<DeleteAmbulanceInfoHandler, bool>
    {
        private readonly IAmbulanceDbContext _context;

        public DeleteEmergencyCallCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }





        public Task<bool> Handle(DeleteAmbulanceInfoHandler request, CancellationToken cancellationToken)
        {
            var emergencyCall = _context.emergencyCalls.FirstOrDefault(x => x.Id == request.Id);

            if (emergencyCall != null)
            {
                _context.emergencyCalls.Remove(emergencyCall);
                _context.SaveChangesAsync(cancellationToken);
                return Task.FromResult(true);
            }
            else
            {


                return Task.FromResult(false);
            }
        }
    }

}