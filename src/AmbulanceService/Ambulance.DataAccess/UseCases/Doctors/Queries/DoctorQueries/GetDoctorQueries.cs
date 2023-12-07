using Ambulance.Domain.Entitites.Doctors;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Doctors.Queries.DoctorQueries
{
    public class GetDoctorQueries : IRequest<IEnumerable<Doctor>>
    {
    }
}
