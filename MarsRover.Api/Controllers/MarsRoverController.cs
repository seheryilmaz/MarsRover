using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarsRover.Business;
using MarsRover.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace MarsRover.Api.Controllers
{
    [Route("mars")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMarsRoverBusiness _marsRoverBusiness;

        public ValuesController(IMarsRoverBusiness marsRoverBusiness)
        {
            _marsRoverBusiness = marsRoverBusiness;
        }

        [HttpPost()]
        public IActionResult Post([FromBody]MarsRoverRequestModel model)
        {
            var response = _marsRoverBusiness.RotateRover(model);
            return Ok(response);
        }
    }
}
