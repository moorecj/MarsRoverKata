﻿using System;
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
        public void AForwardCommandWhileFaceingNorthWillResultInOnePositiveMovementInTheYDirection()
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

        

    }
}
