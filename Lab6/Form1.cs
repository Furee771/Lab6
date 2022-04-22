using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 c = new Class1();
            propertyGrid1.SelectedObject = c;

        }
        void DrawFunction(double x1, double x2, Series series, Equation equation)
        {
            series.Points.Clear();
            int N = 100;
            double h = (x2 - x1) / N;
            for (int i = 0; i < N; i++)
            {
                double x = x1 + i * h;
                double f = equation.GetValue(x1 + i * h);
                series.Points.AddXY(x, f);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var x1 = Convert.ToDouble(textBox1.Text);
            var x2 = Convert.ToDouble(textBox2.Text);
            Equation equation = new QuadEquation(112, 20, -1);
            IntegratorRectangle integr = new IntegratorRectangle(equation);
            double integrValue = integr.Integrate(x1, x2);
            DrawFunction(x1, x2, chart1.Series[0], equation);

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var x1 = Convert.ToDouble(textBox1.Text);
        //    var x2 = Convert.ToDouble(textBox2.Text);
        //    Equation equation = new QuadEquation(112, 20, -1);
        //    IntegratorRectangle integr = new IntegratorRectangle(equation);
        //    double integrValue = integr.Integrate(x1, x2);
        //    DrawFunction(x1, x2, chart1.Series[0], equation);
        //}

        void IntegratorRectangle()
        {
            Equation equation = new FormulaC(10, 20);
            IntegratorRectangle integrator = new IntegratorRectangle(equation);
            var x1 = Convert.ToDouble(textBox1.Text);
            var x2 = Convert.ToDouble(textBox2.Text);
            int N = 100;
            double h = (x2 - x1) / N;
            double sum = 0;
            sum = ((equation.GetValue(x1) + equation.GetValue(x2)) / 2);
            for (int i = 1; i < N - 1; i++)
            {
                double x = x1 + i * h;
                sum += sum + equation.GetValue(x);
            }
            sum = h * sum;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            IntegratorRectangle();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
