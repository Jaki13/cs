using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle :GeometricObject, IDisposable
    {
        private bool disposed;
        protected static int _CountCircles;
        protected double _Radius;

        public Circle()
        {
            _CountCircles++;
        }

        public Circle(double radius) : this()
        {
            Radius = radius;
        }

        public Circle(double radius, int xPos, int yPos) : this(radius)
        {
            XCoordinate = xPos;
            YCoordinate = yPos;
        }

        public static int CountCircles { get => _CountCircles; }

        public virtual double Radius
        {
            get => _Radius;
            set
            {
                if (value >= 0)
                    _Radius = value;
                else
                    Console.WriteLine("Radius kan nicht negativ sein");
            }
        }

        //Methoden
        public override double GetArea()
        {
            double area = 3.14 * Math.Pow(Radius, 2);
            return area;
        }

        public static double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetCircumference()
        {
            double circumference = 2 * Radius * 3.14;
            return circumference;
        }

        public static double GetCircumference(double radius)
        {
            return 2 * radius * Math.PI;
        }

        public virtual void MoveXY(int dx, int dy, int r)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Radius += r;
        }

        public override string ToString()
        {
            return "Circle, R: " + Radius + ", Fläche: " + GetArea();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                _CountCircles--;
                GC.SuppressFinalize(this);
                disposed = true;
            }
        }
        ~Circle()
        {
            Dispose();
        }
    }
}
