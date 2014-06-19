using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsRoverKata
{
    public class MarsRover
    {

        

        private int x;
        private int y;

        enum Directions : byte { North = 0, East, South, West };

        private Directions direction;

        const byte DIRECTION_MASK = 4;


        Dictionary<char, Directions> DirectionLookup = new Dictionary<char, Directions>()
        {
            {'N', Directions.North},
            {'E', Directions.East},
            {'S', Directions.South},
            {'W', Directions.West}
        };

       

        public MarsRover( int x, int y, char directionChar )
        {

            this.x = x;
            this.y = y;
            DirectionLookup.TryGetValue(directionChar, out direction);

        }

        public MarsRover ()
        {
            this.x = 0;
            this.y = 0;
            this.direction = (byte)Directions.North;

        }

        public int GetXCoordinate()
        {
            return (this.x);
        }

        public int GetYCoordinate()
        {
            return (this.y);
        }

        public void Command( char[] command )
        {

            if(command[0] ==  'f')
            {
                MoveSpaces(1);
            }
            else if( command[0] ==  'b' )
            {
                MoveSpaces(-1);
            }


        }

        public char GetCurrentDirection()
        {
            return (DirectionLookup.FirstOrDefault(d => d.Value == direction).Key);
        }

        private void MoveSpaces(int numberOfSpaces)
        {
            switch (direction)
            {
                case Directions.North:
                    y +=  numberOfSpaces;
                    break;

                case Directions.South:
                    y -=  numberOfSpaces;;
                    break;

                case Directions.East:
                    x +=  numberOfSpaces;
                    break;

                case Directions.West:
                    x -=  numberOfSpaces;;
                    break;

            }
        }



   
    }
}
