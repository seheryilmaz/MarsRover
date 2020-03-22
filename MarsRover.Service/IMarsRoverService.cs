using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Model;
using MarsRover.Model.Request;
using MarsRover.Model.Response;

namespace MarsRover.Service
{
    public interface IMarsRoverService
    {
        List<MarsRoverPositionAndCoordinatesResponseModel> RotateRovers(MarsRoverRequestModel model);
        char GetDirection(DirectionModel model);
        CoordinatesRequestModel SetPosition(MoveModel model);

    }
}
