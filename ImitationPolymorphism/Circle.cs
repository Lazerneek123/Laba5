using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImitationPolymorphism
{
    public class Circle : Figure
    {
        private int radius;

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = Radius;
            }
        }

        public Circle()
        {

        }

        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public Circle(int x, int y, int radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        
        public override void DrawBlack()
        {
            ColorFigure = Color.Black;
        }

        public override void HideDrawingBackGround()
        {
            ColorFigure = Color.White;
        }
    }
}


