using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    //Delegate
    public delegate void InvalidBeiteEventHandler(Object sender, InvalidEigenschaftEventArgs e);
    public delegate void InvalidLängeEventHandler(Object sender, InvalidEigenschaftEventArgs e);

    class Rectangle :GeometricObject, IDisposable
    {
        //Ereignis
        public event InvalidRadiusEventHandler InvalidBreite;
        public event InvalidRadiusEventHandler InvalidLänge;

        protected void OnInvalidBreite(InvalidEigenschaftEventArgs e)
        {
            if (InvalidBreite != null)
                InvalidBreite(this, e);
        }

        protected void OnInvalidLänge(InvalidEigenschaftEventArgs e)
        {
            if (InvalidLänge != null)
                InvalidLänge(this, e);
        }

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
            _Center.X = xPos;
            _Center.Y = yPos;
        }

        public Rectangle(double breite, double länge, Point center) : this(breite, länge)
        {
            _Center = center;
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
                   //Ereignis auslösen
                   if (InvalidBreite != null)
                        InvalidBreite(this, new InvalidEigenschaftEventArgs(value));
                    //Console.WriteLine("Radius kan nicht negativ sein");
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
                   //Ereignis auslösen
                   if (InvalidLänge != null)
                        InvalidLänge(this, new InvalidEigenschaftEventArgs(value));
                    //Console.WriteLine("Radius kan nicht negativ sein");
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
            return "Rectangle, B: " + Breite + ", L: " + Länge + ", Fläche: " + GetArea();
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
