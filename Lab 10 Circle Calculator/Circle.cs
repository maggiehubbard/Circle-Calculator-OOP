using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Circle_Calculator
{
    class Circle
    {

        public Circle(double radius)
        {
            Radius = radius;
        }

        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public static int Counter;


        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return CalculateCircumference().ToString("F");//.ToString("F") formats outputs to have 2 decimal places
        }

        public double CalculateArea()
        {
            return (Math.PI * (Radius * Radius));
        }

        public string CalculateFormattedArea()
        {
            return CalculateArea().ToString("F");
        }

        private string FormatNumber(double x)
        {
            return x.ToString("F");
        }

    }
}
