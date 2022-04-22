using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class IntagrateTrapeze : Integrator
    {
        private readonly Equation equation;

        public IntagrateTrapeze(Equation equation)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            this.equation = equation;
        }

        public override double Integrate(double x1, double x2)
        {
            int N = 100;
            double h = (x2 - x1) / N;
            double sum = 0;
            sum = ((equation.GetValue(x1) + equation.GetValue(x2)) / 2);
            for (int i = 1; i < N - 1; i++)
            {
                double x = x1 + i * h;
                sum += sum + equation.GetValue(x);
            }
            return sum = h * sum;
        }

    }
}
