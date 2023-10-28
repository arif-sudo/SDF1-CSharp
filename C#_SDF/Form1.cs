using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__SDF
{
    public partial class Form1 : Form
    {
        public string ClickedButton;
        public string speed = "20";
        public double SideOfSquare;
        public double RadiusOfCircle;
        public double WidthOfRectangle;
        public double HeightOfRectangle;

        public string ColorOfSquare;
        public string ColorOfCircle;
        public string ColorOfRectangle;

        public bool IsFilledOfSquare = true;
        public bool IsFilledOfCircle = true;
        public bool IsFillesOfRectangle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void circle_Click(object sender, EventArgs e)
        {
            ClickedButton = "Circle";
            Circle c = new Circle();

            if (textBox1.Text.Length != 0)
            {
                string text = textBox1.Text;
                string[] parts = text.Split(',').Select(part => part.Trim()).ToArray();

                if (parts.Length == 3)
                {
                    double.TryParse(parts[0], out double radius);
                    string color = parts[1];
                    bool.TryParse(parts[2], out bool filled);    
                    c.Radius = radius;
                    c.Color = color;
                    c.isFilled = filled;
                }
                else
                {
                    MessageBox.Show("Please provied 3 arguments through comma");
                    return;
                }
            }
            ColorOfCircle = c.Color;
            RadiusOfCircle = c.Radius;
            IsFilledOfCircle = c.isFilled;

            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            ClickedButton = "Rectangle";
            Rectangle rectangle = new Rectangle();

            if (textBox1.Text.Length != 0)
            {
                string text = textBox1.Text;
                string[] parts = text.Split(',').Select(part => part.Trim()).ToArray() as string[];

                if (parts.Length == 4)
                {
                    double.TryParse(parts[0], out double width);
                    double.TryParse(parts[1], out double height);
                    string color = parts[2];
                    bool.TryParse(parts[3], out bool filled);

                    rectangle.isFilled = filled;
                    rectangle.Color = color;
                    rectangle.Width = width;
                    rectangle.Height = height;
                }else
                {
                    MessageBox.Show("Please provied 4 arguments through comma");
                    return;
                }

                ColorOfRectangle = rectangle.Color;
                WidthOfRectangle = rectangle.Width;
                HeightOfRectangle = rectangle.Height;
                IsFillesOfRectangle = rectangle.isFilled;

                Form2 form2 = new Form2(this);
                form2.ShowDialog();

            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            ClickedButton = "Square";
            Square s = new Square();

            if (textBox1.Text.Length != 0)
            {
                string text = textBox1.Text;
                string[] parts = text.Split(',').Select(part => part.Trim()).ToArray() as string[];

                if (parts.Length == 3)
                {
                    double.TryParse(parts[0], out double side);
                    string color = parts[1];
                    bool.TryParse(parts[2], out bool filled);
                    s.isFilled = filled;
                    s.Color = color;
                    s.Side = side;
                }
                else
                {
                    MessageBox.Show("Please provied 3 arguments through comma");
                    return;
                }
            }

            ColorOfSquare = s.Color;
            SideOfSquare = s.Side;
            IsFilledOfSquare = s.isFilled;

            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}
