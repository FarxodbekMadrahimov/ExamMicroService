using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Handler.AmbulanceInfoHandler
{
    public class UpdateAmbulanceInfoCommandHandler : IRequestHandler<UpdateAmbulanceInfoCommand , int>
    {
        private readonly IAmbulanceDbContext _context;
        public UpdateAmbulanceInfoCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateAmbulanceInfoCommand request, CancellationToken cancellationToken)
        {
            AmbulanceInfo? @ambulanceInfo = await _context.amulanceInfo.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (@ambulanceInfo == null) 
                throw new Exception();
            
            @ambulanceInfo.Id = request.Id;
            @ambulanceInfo.Model = request.Model;
            @ambulanceInfo.Available = request.Available;


            _context.amulanceInfo.Update(@ambulanceInfo);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
