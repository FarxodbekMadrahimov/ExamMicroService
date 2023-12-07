using Ambulance.Application.Absreactions;
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
    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand , int>
    {
        private readonly IAmbulanceDbContext _context;

        public UpdateDoctorCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor? @ambulanceInfo = await _context.doctors.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (@ambulanceInfo == null)
                throw new Exception();

            @ambulanceInfo.Id = request.Id;
            @ambulanceInfo.Name = request.Name;
            @ambulanceInfo.Specialization = request.Specialization;  
            @ambulanceInfo.EmergencyCallId = request.EmergencyCallId;



            _context.doctors.Update(@ambulanceInfo);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
