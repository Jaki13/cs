using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public abstract class GeometricObject
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        private static int _CountGeometricObjects;
        public static int CountGeometricObjects
        {
            get { return _CountGeometricObjects; }
        }

        public GeometricObject()
        {
            _CountGeometricObjects++;
        }

        public abstract double GetArea();
        public abstract double GetCircumference();

        public virtual int Bigger(GeometricObject rect)
        {
            if (GetArea() > rect.GetArea())
                return 1;
            else if (GetArea() == rect.GetArea())
                return 0;
            else
                return -1;
        }

        public static int Bigger(GeometricObject rect1, GeometricObject rect2)
        {
            if (rect1.GetArea() > rect2.GetArea())
                return 1;
            else if (rect1.GetArea() == rect2.GetArea())
                return 0;
            else
                return -1;
        }

        public virtual void MoveXY(int dx, int dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

    }
}
