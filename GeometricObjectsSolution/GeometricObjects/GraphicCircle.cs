using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class GraphicCircle :Circle
    {
        public GraphicCircle() { }

        public GraphicCircle(double radius) : base(radius) { }

        public GraphicCircle(double radius, int xPos, int yPos) : base(radius, xPos, yPos) { }

        public void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet.");
        }
    }
}
