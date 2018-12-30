using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        private static int _CountCircles;
        private int _XCoordinate { get; set; }
        private int _YCoordinate { get; set; }
        private double _Radius;

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
        public double Radius
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
        public double GetArea()
        {
            double area = 3.14 * Math.Pow(Radius, 2);
            return area;
        }

        public static double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetCircumference()
        {
            double circumference = 2 * Radius * 3.14;
            return circumference;
        }

        public static double GetCircumference(double radius)
        {
            return 2 * radius * Math.PI;
        }

        public void MoveXY(int dx, int dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public void MoveXY(int dx, int dy, int r)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Radius += r;
        }


        public int Bigger(Circle kreis)
        {
            if (Radius > kreis.Radius)
                return 1;
            else if (Radius == kreis.Radius)
                return 0;
            else
                return -1;
        }

        public static int Bigger(Circle kreis1, Circle kreis2)
        {
            if (kreis1.Radius > kreis2.Radius)
                return 1;
            else if (kreis1.Radius == kreis2.Radius)
                return 0;
            else
                return -1;
        }
    }
}
