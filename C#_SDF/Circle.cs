using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__SDF
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        const double PI = Math.PI;

        public Circle() : base()
        {
            Radius = 1.0;
        }

        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return "This is a shape in circle class.";
        }

        public double GetArea()
        {
            return Math.Round((PI * Radius * Radius), 3);
        }

        public double GetPerimeter(double Radius)
        {
            return Math.Round((2 * PI * Radius), 3);
        }

    }
}
