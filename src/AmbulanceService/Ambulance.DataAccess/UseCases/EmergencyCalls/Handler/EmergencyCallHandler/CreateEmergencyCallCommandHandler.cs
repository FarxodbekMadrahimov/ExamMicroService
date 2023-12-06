using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand;
using Ambulance.Domain.Entitites.EmergencyCalls;
using MediatR;

namespace Ambulance.Application.UseCases.EmergencyCalls.Handler.EmergencyCallHandler
{
    public class CreateEmergencyCallCommandHandler : AsyncRequestHandler<CreateEmergencyCallCommnad>
    {
        private readonly IAmbulanceDbContext _context;


        public CreateEmergencyCallCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateEmergencyCallCommnad request, CancellationToken cancellationToken)
        {
            var emergencyCall = new EmergencyCalling
            {
                CallerName = request.CallerName,
                Location = request.Location,
                TimeOfCall = request.TimeOfCall,
                AmbulanceDispatched = request.AmbulanceIsDispatched,
                AmbulanceId = request.AmbulanceId
            };
            _context.emergencyCalls.Add(emergencyCall);
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}

