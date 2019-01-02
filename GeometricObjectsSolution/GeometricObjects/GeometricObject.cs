using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    //Delegates
    public delegate void MovingEventHandler(Object sender, MovingEventArgs e);
    public delegate void MovedEventHandler(Object sender, MovedEventArgs e);

    public abstract class GeometricObject
    {
        // Ereignisse
        public event MovingEventHandler Moving;
        public event MovedEventHandler Moved;
        // geschützte Methoden
        protected void OnMoving(MovingEventArgs e)
        {
            if (Moving != null)
                Moving(this, e);
        }
        protected void OnMoved(MovedEventArgs e)
        {
            if (Moved != null)
                Moved(this, e);
        }

        protected Point _Center = new Point();
        public int XCoordinate {
            get { return _Center.X; }
            set { _Center.X = value; }
        }
        public int YCoordinate { 
            get { return _Center.Y; }
            set { _Center.Y = value; }
        }

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
            // Moving-Ereignis
            MovingEventArgs e = new MovingEventArgs();
            OnMoving(e);
            if (e.Cancel == true)
                return;

            XCoordinate += dx;
            YCoordinate += dy;

            // Moved-Ereignis
            OnMoved(new MovedEventArgs(XCoordinate, YCoordinate));
        }

        public void MoveXY(Point center)
        {
            _Center = center;
        }
    }
}
