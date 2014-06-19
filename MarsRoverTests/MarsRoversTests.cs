using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MarsRoverKata;


namespace MarsRoverTests
{
    [TestFixture]
    public class MarsRoversTests
    {
        [Test]
        public void AMarsRoverExists()
        {
            MarsRover rover = new MarsRover();

            Assert.That(rover, Is.Not.Null);
        }

        [Test]
        public void TheRoverShouldTakeAnInitialStartingPointAndADirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction );

            Assert.That(rover, Is.Not.Null);

        }

        [Test]
        public void RoverShouldReturnItsCoordinates()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.GetXCoordinate();
            rover.GetYCoordinate();


            Assert.That(rover.GetXCoordinate(), Is.EqualTo(0));
            Assert.That(rover.GetYCoordinate(), Is.EqualTo(0));

        }

        [Test]
        public void TheRoverShouldTakeCommand()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'f' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.Command(command);

            Assert.That(rover, Is.Not.Null);

        }

        [Test]
        public void ForwardCommandFaceingNorth_ResultsInOnePositiveMovementInTheYDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'f' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.Command(command);

            Assert.That(rover.GetYCoordinate(), Is.EqualTo(YCoordinate+1));
            Assert.That(rover.GetXCoordinate(), Is.EqualTo(XCoordinate));

        }


        [Test]
        public void ForwardCommandFaceingSouth_ResultsInOneNegitiveMovementInTheYDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'S';

            char[] command = { 'f' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.Command(command);

            Assert.That(rover.GetYCoordinate(), Is.EqualTo(YCoordinate-1));
            Assert.That(rover.GetXCoordinate(), Is.EqualTo(XCoordinate));

        }

        [Test]
        public void ForwardCommandFaceingEast_ResultsInOnePositiveMovementInTheXDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'E';

            char[] command = { 'f' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.Command(command);

            Assert.That(rover.GetYCoordinate(), Is.EqualTo(YCoordinate));
            Assert.That(rover.GetXCoordinate(), Is.EqualTo(XCoordinate+1));

        }

        [Test]
        public void ForwardCommandFaceingWest_ResultsInOneNegitiveMovementInTheXDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'W';

            char[] command = { 'f' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.Command(command);

            Assert.That(rover.GetYCoordinate(), Is.EqualTo(YCoordinate));
            Assert.That(rover.GetXCoordinate(), Is.EqualTo(XCoordinate-1));

        }

        [Test]
        public void BackwardCommandFaceingNorth_ResultsInOneNegitiveMovementInTheYDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'b' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            rover.Command(command);

            Assert.That(rover.GetYCoordinate(), Is.EqualTo(YCoordinate - 1));
            Assert.That(rover.GetXCoordinate(), Is.EqualTo(XCoordinate));

        }

        [Test]
        public void YouShouldBeAbleToGetTheCurrentDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'b' };

            MarsRover rover = new MarsRover(XCoordinate, YCoordinate, direction);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('N'));

        }

        [Test]
        public void FacingNorthATurnRight_ResultsInFacingEast()
        {

            char direction = 'N';

            char[] command = { 'r'};

            MarsRover rover = new MarsRover(0, 0, direction);

            rover.Command(command);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('E'));

        }

        [Test]
        public void FacingNorthATurnLeft_ResultsInFacingWest()
        {

            char direction = 'N';

            char[] command = { 'l' };

            MarsRover rover = new MarsRover(0, 0, direction);

            rover.Command(command);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('W'));

        }








      

        

    }
}
