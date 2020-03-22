using MarsRover.Model.Request;
using MarsRover.Model.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business
{
    public interface IMarsRoverBusiness
    {
        List<MarsRoverPositionAndCoordinatesResponseModel> RotateRover(MarsRoverRequestModel model);
    }
}
