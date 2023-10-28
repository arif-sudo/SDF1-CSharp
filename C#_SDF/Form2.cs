using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__SDF
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private int centerX;
        private int centerY;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.form1 = form1;
            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;
            this.Paint += Form2_Paint;

            centerX = this.ClientSize.Width / 2;
            centerY = this.ClientSize.Height / 2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (form1.ClickedButton == "Circle")
            {
                Move(form1.RadiusOfCircle, form1.RadiusOfCircle, e);
            }
            else if (form1.ClickedButton == "Square")
            {
                Move(form1.SideOfSquare / 2, form1.SideOfSquare / 2, e);
            }
            else if (form1.ClickedButton == "Rectangle")
            {
                Move(form1.WidthOfRectangle / 2, form1.HeightOfRectangle / 2, e);
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (form1.ClickedButton == "Circle")
            {
                string colorNameForCircle = form1.ColorOfCircle;
                Color customColor = Color.FromName(colorNameForCircle);
                Pen customPen = new Pen(customColor, 2);

                int circleRadius = (int)form1.RadiusOfCircle;
                int x = centerX - (circleRadius / 2);
                int y = centerY - (circleRadius / 2);

                if (form1.IsFilledOfSquare)
                {
                    Brush customBrush = new SolidBrush(customColor);
                    e.Graphics.FillEllipse(customBrush, x, y, circleRadius, circleRadius);
                    customBrush.Dispose();
                }
                else
                {
                    e.Graphics.DrawEllipse(customPen, x, y, circleRadius, circleRadius);
                }

                customPen.Dispose();
            }else if (form1.ClickedButton == "Square")
            {
                string colorNameForSquare = form1.ColorOfSquare;
                Color customColor = Color.FromName(colorNameForSquare);
                Pen customPen = new Pen(customColor, 2);

                int squareSize = (int)form1.SideOfSquare;
                int x = centerX - (squareSize / 2);
                int y = centerY - (squareSize / 2);

                if (form1.IsFilledOfSquare)
                {
                    Brush customBrush = new SolidBrush(customColor);
                    e.Graphics.FillRectangle(customBrush, x, y, squareSize, squareSize);
                    customBrush.Dispose();
                }
                else
                {
                    e.Graphics.DrawRectangle(customPen, x, y, squareSize, squareSize);
                }

                customPen.Dispose();
            }else if (form1.ClickedButton == "Rectangle")
            {
                string colorNameForRectangle = form1.ColorOfRectangle;
                Color customColor = Color.FromName(colorNameForRectangle);
                Pen customPen = new Pen(customColor, 2);

                int rectangleWidth = (int)form1.WidthOfRectangle;
                int rectangleHeight = (int)form1.HeightOfRectangle;

                int x = centerX - (rectangleWidth / 2);
                int y = centerY - (rectangleHeight / 2);

                if (form1.IsFillesOfRectangle)
                {
                    Brush customBrush = new SolidBrush(customColor);
                    e.Graphics.FillRectangle(customBrush, x, y, rectangleWidth, rectangleHeight);
                    customBrush.Dispose();
                }else
                {
                    e.Graphics.DrawRectangle(customPen, x, y, rectangleWidth, rectangleHeight);
                }

            }
        }

        private void Move(double width, double height, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                centerX += Convert.ToInt32(form1.speed);
                if (centerX >= this.ClientSize.Width - (int)width)
                {
                    centerX = this.ClientSize.Width - (int)width;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                centerX -= Convert.ToInt32(form1.speed);
                if (centerX < (int)width)
                {
                    centerX = (int)width;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                centerY -= Convert.ToInt32(form1.speed);
                if (centerY < (int)height)
                {
                    centerY = (int)height;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                centerY += Convert.ToInt32(form1.speed);
                if (centerY >= this.ClientSize.Height - (int)height)
                {
                    centerY = this.ClientSize.Height - (int)height;
                }

            }

            Invalidate();
        }
    }
}
