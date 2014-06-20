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
            Point startingLoaction = new Point(0, 0);

            MarsRover rover = new MarsRover(startingLoaction, 'N');

            Assert.That(rover, Is.Not.Null);
        }

        [Test]
        public void TheRoverShouldTakeAnInitialStartingPointAndADirection()
        {
            Point startingLoaction = new Point(0, 0);

            MarsRover rover = new MarsRover(startingLoaction, 'N');

            Assert.That(rover, Is.Not.Null);

        }

        [Test]
        public void RoverShouldReturnItsLocation()
        {
            Point startingLoaction = new Point(0, 0);

            MarsRover rover = new MarsRover(startingLoaction, 'N');

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(startingLoaction));


        }

        [Test]
        public void TheRoverShouldTakeCommand()
        {
            Point startingLoaction = new Point(0, 0);

            MarsRover rover = new MarsRover(startingLoaction, 'N');

            char[] command = { 'f' };

            rover.Command(command);

            Assert.That(rover, Is.Not.Null);

        }

        [Test]
        public void ForwardCommandFaceingNorth_ResultsInOnePositiveMovementInTheYDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            Point startingLoaction = new Point(XCoordinate, YCoordinate);

            MarsRover rover = new MarsRover(startingLoaction, 'N');

            char[] command = { 'f' };

            rover.Command(command);

            Point expectedNewLocation = new Point(XCoordinate, YCoordinate + 1);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }


        [Test]
        public void ForwardCommandFaceingSouth_ResultsInOneNegitiveMovementInTheYDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 1;

            char direction = 'S';

            Point startingLoaction = new Point(XCoordinate, YCoordinate);

            MarsRover rover = new MarsRover(startingLoaction, direction);

            char[] command = { 'f' };

            rover.Command(command);

            Point expectedNewLocation = new Point(XCoordinate, YCoordinate - 1);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }

        [Test]
        public void ForwardCommandFaceingEast_ResultsInOnePositiveMovementInTheXDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;
            char direction = 'E';

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            char[] command = { 'f' };

            rover.Command(command);

            Point expectedNewLocation = new Point(XCoordinate + 1, YCoordinate);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }

        [Test]
        public void ForwardCommandFaceingWest_ResultsInOneNegitiveMovementInTheXDirection()
        {
            int XCoordinate = 1;
            int YCoordinate = 0;

            char direction = 'W';

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            char[] command = { 'f' };

            rover.Command(command);

            Point expectedNewLocation = new Point(XCoordinate - 1, YCoordinate);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }

        [Test]
        public void BackwardCommandFaceingNorth_ResultsInOneNegitiveMovementInTheYDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 1;

            char direction = 'N';

            char[] command = { 'b' };

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            rover.Command(command);

            Point expectedNewLocation = new Point(XCoordinate, YCoordinate - 1);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }

        [Test]
        public void YouShouldBeAbleToGetTheCurrentDirection()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'b' };

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('N'));

        }

        [Test]
        public void FacingNorthATurnRight_ResultsInFacingEast()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = {'r'};

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            rover.Command(command);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('E'));

        }

        [Test]
        public void FacingNorthATurnLeft_ResultsInFacingWest()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'l' };

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            rover.Command(command);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('W'));

        }

        [Test]
        public void FacingNorthFourLefts_ResultsInFacingNorth()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'N';

            char[] command = { 'l','l','l','l'};

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            rover.Command(command);

            Assert.That(rover.GetCurrentDirection(), Is.EqualTo('N'));

        }


        [Test]
        public void GoingOverTheEdge_ResultsInGoingToTheOtherSideOfTheGrid()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'S';

            char[] command = {'f'};

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            rover.Command(command);

            Point expectedNewLocation = new Point(XCoordinate, MarsRover.WORLD_SIZE);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }


        [Test]
        public void RunningIntoAnObstacleShouldBeReported()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'E';

            char[] command = { 'f', 'f', 'f', 'f' };

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction);

            rover.Command(command);

            Assert.That(rover.HitObstacle(), Is.EqualTo(true));
           

        }

        [Test]
        public void RunningIntoAnObstacleShouldStopTheRoverAtTheLocationBeforeTheObstacle()
        {
            int XCoordinate = 0;
            int YCoordinate = 0;

            char direction = 'E';

            char[] command = { 'f', 'f', 'f', 'f' };

            Point obstacle = new Point(3, 0);

            List<Point> obstacles = new List<Point>();

            obstacles.Add(obstacle);

            Point startingLoaction = new Point(XCoordinate, YCoordinate);
            MarsRover rover = new MarsRover(startingLoaction, direction, obstacles);

            rover.Command(command);

            Point expectedNewLocation = new Point(2,0);

            Assert.That(rover.GetCurrentLocation(), Is.EqualTo(expectedNewLocation));

        }











      

        

    }
}
