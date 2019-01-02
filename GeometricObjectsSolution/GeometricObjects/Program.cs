using System;
using System.Collections;
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
            Circle kreis = new Circle();
            kreis.InvalidRadius += kreis_InvalidRadius;
            kreis.Radius = -10;
            kreis.MoveXY(new Point(3, 4));
            Console.WriteLine(kreis.ToString());

            GraphicCircle kreisgr = new GraphicCircle();
            kreisgr.InvalidRadius += kreis_InvalidRadius;
            kreisgr.Radius = -13;
            Console.WriteLine(kreisgr.ToString());

            Rectangle rec = new Rectangle();
            rec.InvalidBreite += Rec_InvalidBreite;
            rec.InvalidLänge += Rec_InvalidLänge;
            rec.Breite = -3;
            rec.Länge = -1;
            Console.WriteLine(rec.ToString());

            GraphicRectangle recgr = new GraphicRectangle();
            recgr.InvalidBreite += Rec_InvalidBreite;
            recgr.InvalidLänge += Rec_InvalidLänge;
            recgr.Breite = -3;
            recgr.Länge = -1;
            Console.WriteLine(recgr.ToString());

            Console.ReadLine();
        }

        private static void Rec_InvalidBreite(object sender, InvalidEigenschaftEventArgs e)
        {
            Console.WriteLine("Eine Breite von {0} ist nicht zulässig.", e.Eigenschaft);
            Console.Write("Neueingabe: ");
            ((Rectangle)sender).Breite = Convert.ToDouble(Console.ReadLine());
        }

        private static void Rec_InvalidLänge(object sender, InvalidEigenschaftEventArgs e)
        {
            Console.WriteLine("Eine Länge von {0} ist nicht zulässig.", e.Eigenschaft);
            Console.Write("Neueingabe: ");
            ((Rectangle)sender).Länge = Convert.ToDouble(Console.ReadLine());
        }

        public static void kreis_InvalidRadius(object sender, InvalidEigenschaftEventArgs e)
        {
            Console.WriteLine("Ein Radius von {0} ist nicht zulässig.", e.Eigenschaft);
            Console.Write("Neueingabe: ");
            ((Circle)sender).Radius = Convert.ToDouble(Console.ReadLine());
        }
    }
}
