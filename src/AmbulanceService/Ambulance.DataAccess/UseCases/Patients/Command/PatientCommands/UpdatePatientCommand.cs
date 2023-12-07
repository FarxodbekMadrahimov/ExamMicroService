using Ambulance.Domain.updateDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Patients.Command.PatientCommands
{
    public class UpdatePatientCommand : PatientUpdateDto , IRequest<int>
    {
    }
}
