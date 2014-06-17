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

    }
}
