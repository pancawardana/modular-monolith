using MediatR;
using Microsoft.AspNetCore.Mvc;
using ODS.DataEntry.Modules.WellMaster.Application.Command;

namespace ODS.DataEntry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WellMasterController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WellMasterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetWellMasterCommand());
            return Ok(result);
        }
    }
}
