using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Point : IEquatable<Point>
    {
        private int x;
        private int y;

        private const int WORLD_SIZE = 32;


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int GetXCoordinate()
        {
            return((this.x) & (WORLD_SIZE-1));
        }

        public int GetYCoordinate()
        {
            return ((this.y) & (WORLD_SIZE - 1));
        }

        public void MoveX( int spaces )
        {
            x += spaces;
        }

        public void MoveY( int spaces )
        {
            y += spaces;
        }

        public bool Equals(Point other)
        {
            if (other == null)
                return false;

            if (((this.GetXCoordinate() - other.GetXCoordinate()) == 0) && ((this.GetYCoordinate() - other.GetYCoordinate()) == 0))
            {
                return true;
            }
            else
                return false;

        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Point pointObj = obj as Point;
            if (pointObj == null)
                return false;
            else
                return Equals(pointObj);
        }

        public static bool operator ==(Point point1, Point point2)
        {
            if ((object)point1 == null || ((object)point2) == null)
                return Object.Equals(point1, point2);

            return point1.Equals(point2);
        }

        public static bool operator !=(Point point1, Point point2)
        {
            if (point1 == null || point2 == null)
                return !Object.Equals(point1, point2);

            return !(point1.Equals(point2));
        }


    }

    
}
