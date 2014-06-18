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
        private char direction;

        public MarsRover( int x, int y, char direction )
        {

            this.x = x;
            this.y = y;
            this.direction = direction;

        }

        public MarsRover ()
        {
            this.x = 0;
            this.y = 0;
            this.direction = 'N';
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
                if (direction == 'N')
                    ++y;
            }
        }
    }
}
