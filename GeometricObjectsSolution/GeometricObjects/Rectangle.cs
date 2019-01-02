using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Rectangle :GeometricObject :IDisposable
    {
        private bool disposed;
        protected static int _CountRectangles;
        protected double _Breite;
        protected double _Länge;

        public Rectangle()
        {
            _CountRectangles++;
        }

        public Rectangle(double breite, double länge) : this()
        {
            Breite = breite;
            Länge = länge;
        }

        public Rectangle(double breite, double länge, int xPos, int yPos) : this(breite, länge)
        {
            XCoordinate = xPos;
            YCoordinate = yPos;
        }

        public static int CountRectangles { get => _CountRectangles; }
        public virtual double Breite
        {
            get => _Breite;
            set
            {
                if (value >= 0)
                    _Breite = value;
                else
                    Console.WriteLine("Breite kan nicht negativ sein");
            }
        }

        public virtual double Länge
        {
            get => _Länge;
            set
            {
                if (value >= 0)
                    _Länge = value;
                else
                    Console.WriteLine("Länge kan nicht negativ sein");
            }
        }

        //Methoden
        public override double GetArea()
        {
            double area = Breite * Länge;
            return area;
        }

        public static double GetArea(double breite, double länge)
        {
            return breite * länge;
        }

        public override double GetCircumference()
        {
            double circumference = 2 * Breite + 2 * Länge;
            return circumference;
        }

        public static double GetCircumference(double breite, double länge)
        {
            return 2 * breite + 2 * länge;
        }

        public virtual void MoveXY(int dx, int dy, int b, int h)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Breite += b;
            Länge += h;
        }

        public override string ToString()
        {
            return "Rectangle, B: " + Breite + ", H: " + Länge + ", Fläche: " + GetArea();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                _CountRectangles--;
                GC.SuppressFinalize(this);
                disposed = true;
            }
        }

        ~Rectangle()
        {
            Dispose();
        }
    }
}
