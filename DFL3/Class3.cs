using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFL3
{
    public class Class3
    {
        public double D(double a, double b) { if (b == 0) { throw new DivideByZeroException("Делить на нуль нельзя:)"); } return a / b; }
    }
}
