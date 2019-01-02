using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class GraphicRectangle :Rectangle
    {
        public GraphicRectangle() { }

        public GraphicRectangle(double breite, double länge) : base(breite, länge) { }

        public GraphicRectangle(double breite, double länge, int xPos, int yPos) : base(breite, länge, xPos, yPos) { }

        public void Draw()
        {
            Console.WriteLine("Der Rechteck wird gezeichnet.");
        }
    }
}
