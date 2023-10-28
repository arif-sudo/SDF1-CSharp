using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__SDF
{
    internal class Shape
    {
        public string Color { get; set; }
        public bool isFilled { get; set; }

        public Shape() 
        {
            this.Color = "Red";
            this.isFilled = true;
        }
        public Shape(string color, bool isFilled)
        {
            this.Color = color;
            this.isFilled = isFilled;
        }
        public virtual string ToString()
        {
            return "This is a shape in base class.";
        }
     

    }
}
