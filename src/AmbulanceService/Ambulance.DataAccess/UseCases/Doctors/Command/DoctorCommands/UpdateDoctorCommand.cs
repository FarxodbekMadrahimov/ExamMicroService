using Ambulance.Domain.updateDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Doctors.Command.DoctorCommands
{
    public class UpdateDoctorCommand : DoctorUpdateDto, IRequest<int>
    {
    }
}
