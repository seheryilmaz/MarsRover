using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model.Request
{
    public class MarsRoverPositionAndCoordinatesRequestModel
    {
        public CoordinatesRequestModel Coordinates { get; set; }
        public char Direction { get; set; }
        public string Instruction { get; set; }
    }
}
