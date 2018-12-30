using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis = new Circle { Radius = 10, XCoordinate = -23, YCoordinate = 14};
            kreis.Radius = 11;
            Console.WriteLine("Der Keisradius beträgt {0} Einheiten.", kreis.Radius);

            double area = kreis.GetArea();
            Console.WriteLine("Der Flächeninhalt beträgt {0} Einheiten^2", area);

            Console.WriteLine("Der Umfang beträgt {0} Einheiten", kreis.GetCircumference());

            kreis.MoveXY(51, -15);

            Console.WriteLine("X = {0}\nY = {1}", kreis.XCoordinate, kreis.YCoordinate);

            Circle kreis2 = new Circle { Radius = 7, XCoordinate = 1, YCoordinate = 0 };

            Console.WriteLine("Kreis größer als Kreis2? : " + kreis.Bigger(kreis2));

            Console.Read();

           
        }
    }
}
