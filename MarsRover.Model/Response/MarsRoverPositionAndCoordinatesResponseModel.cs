using MarsRover.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model.Response
{
    public class MarsRoverPositionAndCoordinatesResponseModel
    {
        public CoordinatesRequestModel Coordinates { get; set; }
        public char Direction { get; set; }
    }
}
