using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationPolymorphism
{
    public partial class ImitationPolymorphismForm : Form
    {
        public ImitationPolymorphismForm()
        {
            InitializeComponent();
        }
      
        Bitmap bmp;
        Graphics graphics;

        Circle circle;
        Square square;
        Rhomb rhomb;

        public void CircleDraw()
        {
            circle = new Circle(315, 120, 40);
            circle.DrawBlack();
        }

        public void SquareDraw()
        {
            square = new Square(315, 120, 45);
            square.DrawBlack();
        }

        public void RhombDraw()
        {
            rhomb = new Rhomb(100 + 235, 160 - 60, 80 + 235, 200 - 60, 120 + 235, 240 - 60);
            rhomb.DrawBlack();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BCircle_Click(object sender, EventArgs e)
        {
            CircleDraw();            
            n = 1;
            timer1.Start();              
        }

        private void BSquare_Click(object sender, EventArgs e)
        {
            SquareDraw();
            n = 2;
            timer1.Start();
        }

        private void BRhomb_Click(object sender, EventArgs e)
        {
            RhombDraw();            
            n = 3;
            timer1.Start();
            
        }

        int k = 0;
        int n = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == 1)
            {
                k += circle.MoveRight();

                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Pen pen_1 = new Pen(circle.ColorFigure, 40);

                graphics = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
                label1.Text = "Статус: Коло";

                if (k >= 676 - 350)
                {
                    circle.HideDrawingBackGround();
                    pen_1 = new Pen(circle.ColorFigure, 40);
                    graphics.DrawEllipse(pen_1, circle.x, circle.y, circle.Radius, circle.Radius);
                    k = 0;
                    n = 0;
                    label1.Text = "Статус:";
                    timer1.Stop();
                }
                else
                {
                    graphics.DrawEllipse(pen_1, circle.x + k, circle.y, circle.Radius, circle.Radius);

                }

            }

            if (n == 2)
            {
                k += square.MoveRight();

                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Pen pen_1 = new Pen(square.ColorFigure, 45);

                graphics = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
                label1.Text = "Статус: Прямокутник";

                if (k >= 676 - 350)
                {
                    square.HideDrawingBackGround();
                    pen_1 = new Pen(square.ColorFigure, 45);
                    graphics.DrawRectangle(pen_1, square.x, square.y, square.SideLength, square.SideLength);
                    k = 0;
                    n = 0;
                    label1.Text = "Статус:";
                    timer1.Stop();
                }
                else
                {
                    graphics.DrawRectangle(pen_1, square.x + k, square.y, square.SideLength, square.SideLength);

                }

            }

            if (n == 3)
            {
                k += rhomb.MoveRight();

                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Pen pen_1 = new Pen(rhomb.ColorFigure, 36);

                graphics = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
                label1.Text = "Статус: Ромб";

                if (k >= 676 - 350)
                {
                    rhomb.HideDrawingBackGround();
                    pen_1 = new Pen(rhomb.ColorFigure, 36);
                    Point[] PointsRomb = new Point[4];

                    PointsRomb[0] = new Point(rhomb.x, rhomb.y);
                    PointsRomb[1] = new Point(rhomb.X2, rhomb.Y2);
                    PointsRomb[2] = new Point(rhomb.x, rhomb.Y3);
                    PointsRomb[3] = new Point(rhomb.X3, rhomb.Y2);

                    graphics.DrawPolygon(pen_1, PointsRomb);
                    k = 0;
                    n = 0;
                    label1.Text = "Статус:";
                    timer1.Stop();
                }
                else
                {
                    Point[] PointsRomb = new Point[4];

                    PointsRomb[0] = new Point(rhomb.x + k, rhomb.y);
                    PointsRomb[1] = new Point(rhomb.X2 + k, rhomb.Y2);
                    PointsRomb[2] = new Point(rhomb.x + k, rhomb.Y3);
                    PointsRomb[3] = new Point(rhomb.X3 + k, rhomb.Y2);

                    graphics.DrawPolygon(pen_1, PointsRomb);

                }
                
            }            
        }
    }
}
