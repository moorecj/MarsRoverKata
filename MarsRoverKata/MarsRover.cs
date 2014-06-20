using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsRoverKata
{
    public class MarsRover
    {

        private Point marsRoverLocation;

        enum Directions : byte { North = 0, East, South, West };

        private Directions direction;

        private const byte DIRECTION_MASK = 3;
        public const int WORLD_SIZE = 31;

        bool ObstacleHitStatus;

        List<Point> Obstacles;

        Dictionary<char, Directions> DirectionLookup = new Dictionary<char, Directions>()
        {
            {'N', Directions.North},
            {'E', Directions.East},
            {'S', Directions.South},
            {'W', Directions.West}
        };

        public MarsRover( Point startingPoint, char directionChar )
        {
            marsRoverLocation = startingPoint;

            DirectionLookup.TryGetValue(directionChar, out direction);

            ObstacleHitStatus = false;

            Obstacles = new List<Point>();

        }

        public MarsRover( Point startingPoint, char directionChar, List<Point> Obstacles)
        {
            marsRoverLocation = startingPoint;

            DirectionLookup.TryGetValue(directionChar, out direction);

            this.Obstacles = Obstacles;

            ObstacleHitStatus = false;

        }

        public Point GetCurrentLocation()
        {
            return (marsRoverLocation);
        }

        public void Command( char[] commands )
        {
            
            foreach( char c in commands )
            {
                Point oldLocation = new Point(marsRoverLocation.GetXCoordinate(), marsRoverLocation.GetYCoordinate());    
                ImplementCommand( c );

                ObstacleHitStatus = true;

                foreach(Point obstacleLocation in Obstacles)
                {
                    if(marsRoverLocation == obstacleLocation)
                    {
                        marsRoverLocation = oldLocation;
                        ObstacleHitStatus = true;
                        break;
                    }

                    if (ObstacleHitStatus == true)
                        break;
                    
                } 
            }
        }

        public bool HitObstacle()
        {
            return (ObstacleHitStatus);
        }

        private void ImplementCommand( char command)
        {
            switch( command )
            {
                case 'f':
                    MoveSpaces(1, marsRoverLocation);
                    break;

                case 'b':
                    MoveSpaces(-1, marsRoverLocation);
                    break;

                case 'r':
                    direction++;
                    direction = (Directions)((byte)direction & DIRECTION_MASK);
                    break;

                case 'l':
                    direction--;
                    direction = (Directions)((byte)direction & DIRECTION_MASK);
                    break;
            }

        }

        public char GetCurrentDirection()
        {
            return (DirectionLookup.FirstOrDefault(d => d.Value == direction).Key);
        }

        private void MoveSpaces(int numberOfSpaces, Point point)
        {
            switch (direction)
            {
                case Directions.North:
                    point.MoveY(numberOfSpaces);
                    break;

                case Directions.South:
                    point.MoveY(numberOfSpaces * -1);
                    break;

                case Directions.East:
                    point.MoveX(numberOfSpaces);
                    break;

                case Directions.West:
                    point.MoveX(numberOfSpaces * -1);
                    break;

            }
        }



   
    }
}
