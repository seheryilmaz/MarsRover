using MarsRover.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Model.Response;
using MarsRover.Service;

namespace MarsRover.Business
{
    public partial class MarsRoverBusiness : IMarsRoverBusiness
    {
        private readonly IMarsRoverService _marsRoverService;

        public MarsRoverBusiness(IMarsRoverService marsRoverService)
        {
            _marsRoverService = marsRoverService;
        }
        public List<MarsRoverPositionAndCoordinatesResponseModel> RotateRover(MarsRoverRequestModel model)
        {
            try
            {
                RotateRoverBaseValidation(model);
                var result = _marsRoverService.RotateRovers(model);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
