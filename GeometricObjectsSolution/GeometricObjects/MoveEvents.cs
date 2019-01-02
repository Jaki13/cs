using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class MovingEventArgs
    {
        public bool Cancel;
    }

    public class MovedEventArgs : EventArgs
    {
        private int _X;
        private int _Y;

        public MovedEventArgs(int x, int y)
        {
            _X = x;
            _Y = y;
        }

        public int X { get => _X; }
        public int Y { get => _Y; }
    }
}
