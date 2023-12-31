﻿using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Application.UseCases.AmbulanceInfos.Handler.AmbulanceInfoHandler;
using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;


namespace Ambulance.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AmbulanceInfoController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMemoryCache _memCache;

        public AmbulanceInfoController(IMediator mediator, IMemoryCache memCache)
        {
            _mediator = mediator;
            _memCache = memCache;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromForm] CreateAmbulanceInfoCommand AmbulanceInfo)
        {
            int result = await _mediator.Send(AmbulanceInfo);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var cache = _memCache.Get("getallAInfo");

            if(cache == null)
            {
                IEnumerable<AmbulanceInfo> classes = await _mediator.Send(new GetAllAmbulanceInfoQuery());
               
                _memCache.Set("getallAInfo", classes);
            }

            return Ok(_memCache.Get("getallAInfo") as IEnumerable<AmbulanceInfo>);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdateAmbulanceInfoCommand @updateAmbulanceInfoCommandHandler)
        {
            int result = await _mediator.Send(@updateAmbulanceInfoCommandHandler);  
            return Ok(result);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int classId)
        {
            DeleteAmbulanceInfoCommand @class = new DeleteAmbulanceInfoCommand()
            {
                Id = classId
            };

            int result = await _mediator.Send(@class);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int Id)
        {
            var cache = _memCache.Get(Id);

            if (cache == null)
            {
                GetAmbulanceInfoByIdQuery @class = new GetAmbulanceInfoByIdQuery()
                {
                    Id = Id
                };

                AmbulanceInfo result = await _mediator.Send(@class);

                _memCache.Set(Id, result);
            }

            return Ok(_memCache.Get(Id));
        }

    }
}
