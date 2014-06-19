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

        List<Point> Obstacles = new List<Point>{ new Point(0, 3)};


        Dictionary<char, Directions> DirectionLookup = new Dictionary<char, Directions>()
        {
            {'N', Directions.North},
            {'E', Directions.East},
            {'S', Directions.South},
            {'W', Directions.West}
        };

        public MarsRover( int x, int y, char directionChar )
        {
            marsRoverLocation = new Point(x, y);

            DirectionLookup.TryGetValue(directionChar, out direction);

        }

        public int GetXCoordinate()
        {
            return ((marsRoverLocation.GetXCoordinate()) & WORLD_SIZE);
        }

        public int GetYCoordinate()
        {
            return ((marsRoverLocation.GetYCoordinate()) & WORLD_SIZE);
        }

        public void Command( char[] commands )
        {
            foreach( char c in commands )
            {
                Point oldLocation = new Point(marsRoverLocation.GetXCoordinate(), marsRoverLocation.GetYCoordinate());    
                ImplementCommand( c );
                

            }
        }

        private void ImplementCommand( char command)
        {
            switch( command )
            {
                case 'f':
                    MoveSpaces(1);
                    break;

                case 'b':
                    MoveSpaces(-1);
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
