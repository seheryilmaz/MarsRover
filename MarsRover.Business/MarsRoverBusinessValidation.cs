using MarsRover.Model.Request;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MarsRover.Business
{
    public partial class MarsRoverBusiness
    {
        public void RotateRoverBaseValidation(MarsRoverRequestModel model)
        {
            if (model == null)
            {
                throw new Exception("İstek boş bırakılamaz.");
            }

            if (model.Coordinates.XCoordinate == 0 || model.Coordinates.YCoordinate == 0)
            {
                throw new Exception("Roverların gidebileceği maksimum x ve y koordinat bilgilerini girmeniz gerekmektedir.");
            }

            if (model.Coordinates.XCoordinate < 0 || model.Coordinates.YCoordinate < 0)
            {
                throw new Exception("Maksimum sınır verileri 0'dan büyük olmalıdır.");
            }
            foreach (var item in model.RoverPositionAndCoordinates)
            {
                if (item.Coordinates.XCoordinate > model.Coordinates.XCoordinate || item.Coordinates.YCoordinate > model.Coordinates.YCoordinate)
                {
                    throw new Exception(item.Coordinates.XCoordinate + item.Coordinates.YCoordinate
                                                                     + item.Direction + " koordinatları maksimum boyutları aştığından dolayı rover bilgileri olarak girilemez.");
                }
            }
        }
    }
}
