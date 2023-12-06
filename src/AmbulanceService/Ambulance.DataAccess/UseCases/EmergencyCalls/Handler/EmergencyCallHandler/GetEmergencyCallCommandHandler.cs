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
    public class GetEmergencyCallCommandHandler : IRequestHandler<GetEmergencyCallQuery, List<EmergencyCalling>>
    {
        private readonly IAmbulanceDbContext _context;
        public GetEmergencyCallCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public Task<List<EmergencyCalling>> Handle(GetEmergencyCallQuery request, CancellationToken cancellationToken)
        {
            return _context.emergencyCalls.ToListAsync();
        }
    }

}
