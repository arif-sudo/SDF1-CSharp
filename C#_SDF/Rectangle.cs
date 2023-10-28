using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__SDF
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : base()
        {
            this.Width = 2;
            this.Height = 2;
        }
        public Rectangle(double width, double height) : base()
        {
            Width = width;
            Height = height;
        }

        public Rectangle(double width, double height, string color, bool isFilled) : base(color, isFilled)
        {
            this.Width = width;
            this.Height = height;
        }
        public override string ToString()
        {
            return "This is a shape in rectangle class.";
        }

        public double GetArea(double width, double height)
        {
            return width * height;
        }

        public double GetPerimetr(double width, double height)
        {
            return 2 * (width + height);
        }
       

    }
}
