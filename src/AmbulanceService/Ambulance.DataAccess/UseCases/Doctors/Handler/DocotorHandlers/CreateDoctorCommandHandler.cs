using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.Doctors.Command.DoctorCommands;
using Ambulance.Domain.Dtos.DoctorDtos;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Doctors;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Doctors.Handler.DocotorHandlers
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand,int>
    {
        private readonly IAmbulanceDbContext _context;

        public CreateDoctorCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor? ambulanceInfo = await _context.doctors.FirstOrDefaultAsync(cancellationToken);
            if (ambulanceInfo != null)
                throw new Exception();


            Doctor doctor = new Doctor()
            {
                Name = request.Name,
                Specialization = request.Specialization,
                EmergencyCallId = request.EmergencyCallId,
            };
            await _context.doctors.AddAsync(doctor, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
