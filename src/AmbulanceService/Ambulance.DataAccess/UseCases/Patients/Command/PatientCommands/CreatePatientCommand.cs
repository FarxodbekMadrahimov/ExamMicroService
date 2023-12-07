using Ambulance.Domain.Dtos.PatientDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Patients.Command.PatientCommands
{
    public class CreatePatientCommand : PatientDto , IRequest<int>
    {
    }
}
