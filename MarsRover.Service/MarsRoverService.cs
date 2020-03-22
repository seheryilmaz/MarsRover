using MarsRover.Model.Request;
using MarsRover.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using MarsRover.Model;

namespace MarsRover.Service
{
    public class MarsRoverService : IMarsRoverService
    {
        public List<MarsRoverPositionAndCoordinatesResponseModel> RotateRovers(MarsRoverRequestModel model)
        {
            var rovers = new List<MarsRoverPositionAndCoordinatesResponseModel>();
            foreach (var item in model.RoverPositionAndCoordinates)
            {
                char[] instructionArray = item.Instruction.ToString().ToCharArray();
                foreach (var instruction in instructionArray)
                {
                    if (instruction.ToString() == "L" || instruction.ToString() == "R")
                    {
                        item.Direction = GetDirection(new DirectionModel { Direction = item.Direction, MoveChar = instruction });
                    }
                    if (instruction.ToString() == "M")
                    {
                        item.Coordinates = SetPosition(new MoveModel { Position = item.Coordinates, Direction = item.Direction });
                    }
                }

                if (item.Coordinates.XCoordinate < 0 || item.Coordinates.XCoordinate > model.Coordinates.XCoordinate || item.Coordinates.YCoordinate < 0 || item.Coordinates.YCoordinate > model.Coordinates.YCoordinate)
                {
                    throw new Exception("Verilen komutlar maksimum sınırları aşmıştır");
                }

                var rover = new MarsRoverPositionAndCoordinatesResponseModel { Direction = item.Direction, Coordinates = item.Coordinates };
                rovers.Add(rover);
            }

            return rovers;
        }

        public char GetDirection(DirectionModel model)
        {
            char[] directions = { 'N', 'E', 'S', 'W' };

            var indexOfArray = Array.IndexOf(directions, model.Direction);
            if (model.MoveChar == 'L' && indexOfArray == 0)
            {
                indexOfArray = 3;
            }

            else if (model.MoveChar == 'R' && indexOfArray == 3)
            {
                indexOfArray = 0;
            }

            else if (model.MoveChar == 'L')
            {
                indexOfArray = indexOfArray - 1;
            }

            else if (model.MoveChar == 'R')
            {
                indexOfArray = indexOfArray + 1;
            }
            return directions[indexOfArray];
        }

        public CoordinatesRequestModel SetPosition(MoveModel model)
        {

            switch (model.Direction)
            {
                case 'N':
                    model.Position.YCoordinate++;
                    break;
                case 'S':
                    model.Position.YCoordinate--;
                    break;
                case 'E':
                    model.Position.XCoordinate++;
                    break;
                case 'W':
                    model.Position.XCoordinate--;
                    break;

            }

            return model.Position;
        }
    }
}
