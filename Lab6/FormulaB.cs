using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class FormulaB : Equation
    {
        private readonly double _a;

        public FormulaB(double a)
        {
            _a = a;
        }

        public override double GetValue(double x)
        {
            return Math.Sin(_a * x) / x;
        }
    }
}
