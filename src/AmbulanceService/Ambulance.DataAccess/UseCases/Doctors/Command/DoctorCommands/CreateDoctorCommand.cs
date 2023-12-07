using Ambulance.Domain.Dtos.DoctorDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Doctors.Command.DoctorCommands
{
    public class CreateDoctorCommand : DoctorDto , IRequest<int>
    {
    }
}
