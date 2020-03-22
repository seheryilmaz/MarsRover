using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model.Request
{
    public class MarsRoverRequestModel
    {
        public CoordinatesRequestModel Coordinates { get; set; }
        public List<MarsRoverPositionAndCoordinatesRequestModel> RoverPositionAndCoordinates { get; set; }
    }
}
