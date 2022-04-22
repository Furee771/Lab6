using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class FormulaC : Equation
    {
        private readonly double _a;
        private readonly double _b;

        public FormulaC(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double GetValue(double x)
        {
            return x * x * Math.Cos(x - _a) / _b;
        }
    }
}
