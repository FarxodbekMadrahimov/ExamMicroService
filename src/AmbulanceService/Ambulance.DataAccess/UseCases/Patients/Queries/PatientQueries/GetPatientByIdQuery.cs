using Ambulance.Domain.Entitites.Patients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Patients.Queries.PatientQueries
{
    public class GetPatientByIdQuery : IRequest<Patient>
    {
        public int Id { get; set; }
    }
}
