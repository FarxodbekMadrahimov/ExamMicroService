using Ambulance.Domain.Entitites.EmergencyCalls;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.EmergencyCalls.Queries.EmergencyCallQueries
{
    public class GetEmergencyCallQuery : IRequest<List<EmergencyCalling>>
    {

    }
}
