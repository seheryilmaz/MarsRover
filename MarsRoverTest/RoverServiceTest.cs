using MarsRover.Model;
using MarsRover.Model.Request;
using MarsRover.Service;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        private IMarsRoverService _marsRoverService;


        [SetUp]
        public void Setup()
        {
            _marsRoverService = new MarsRoverService();
        }

        [Test]
        public void SetPositionTest()
        {
            var result = new CoordinatesRequestModel {XCoordinate = 1,YCoordinate = 2};
           var expect = _marsRoverService.SetPosition(new MoveModel
               {Position = new CoordinatesRequestModel {XCoordinate = 1, YCoordinate = 1}, Direction = 'N'});
            Assert.AreEqual(expect.YCoordinate, result.YCoordinate);
        }

        [Test]
        public void GetDirectionTest()
        {
          var result = _marsRoverService.GetDirection(new DirectionModel { Direction = 'N', MoveChar = 'L' });
          Assert.AreEqual(result, 'W');
        }

    }
}
