using MarsRover.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model
{
    public class MoveModel
    {
        public CoordinatesRequestModel Position { get; set; }
        public char Direction { get; set; }
    }
}
