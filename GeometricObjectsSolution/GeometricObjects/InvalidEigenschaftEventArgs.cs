using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class InvalidEigenschaftEventArgs :EventArgs
    {
        private double _Eigenschaft;
        public double Eigenschaft { get => _Eigenschaft; }

        public InvalidEigenschaftEventArgs(double eigenschaft)
        {
            _Eigenschaft = eigenschaft;
        }
    }
}
