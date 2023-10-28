using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__SDF
{
    internal class Square : Rectangle
    {
        public double Side {  get; set; }

        public Square() : base()
        {
            this.Side = 2;
        }

        public Square(double side) : base()
        {
            this.Side = side;
        }

        public Square(double side, string color, bool isFilled) : base(side, side, color, isFilled)
        {
        }

        public override string ToString()
        {
            return "This is a shape in square class.";
        }

    }
}
