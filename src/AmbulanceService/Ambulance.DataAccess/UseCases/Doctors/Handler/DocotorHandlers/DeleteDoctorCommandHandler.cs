using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Application.UseCases.Doctors.Command.DoctorCommands;
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
    public class DeleteDoctorCommandHandler : IRequestHandler<DeleteDoctorCommand , int>
    {
        private readonly IAmbulanceDbContext _context;
        public DeleteDoctorCommandHandler(IAmbulanceDbContext context)
        { 
            _context = context;
        }

        public async Task<int> Handle(DeleteDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor? doctor = await _context.doctors.FirstOrDefaultAsync(x => x.Id == request.Id , cancellationToken);

            if (doctor == null)
                throw new Exception();

            _context.doctors.Remove(doctor);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
