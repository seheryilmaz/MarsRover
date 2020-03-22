using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarsRover.Business;
using MarsRover.Model.Request;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarsRover
{
    [Route("mars")]
    [ApiController]
    public class MarsRoverController : Controller
    {
        private readonly IMarsRoverBusiness _marsRoverBusiness;

        public MarsRoverController(IMarsRoverBusiness marsRoverBusiness)
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
