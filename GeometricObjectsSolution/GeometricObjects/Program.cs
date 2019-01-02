using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        GraphicCircle gc = new GraphicCircle();
    //        Console.WriteLine("Anzahl der Kreis Objekte {0}.", GraphicCircle.CountCircles);

    //        Console.Read();


    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            GeometricObject[] arr = new GeometricObject[5];
            arr[0] = new Circle(34);
            arr[1] = new Rectangle(10, 230);
            arr[2] = new GraphicCircle(37);
            arr[3] = new Circle(20);
            arr[4] = new GraphicRectangle(12, 70);
            Array.Sort(arr, new CompareClass());
            foreach (GeometricObject item in arr)
                Console.WriteLine(item.ToString());
            Console.ReadLine();
        }
    }
    class CompareClass : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((GeometricObject)x).Bigger((GeometricObject)y);
        }
    }
}
