using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ImitationPolymorphism
{
    public class Square : Figure
    {
        private int sideLength;
        public int SideLength
        {
            get
            {
                return sideLength;
            }
            set
            {
                sideLength = SideLength;
            }
        }

        public Square()
        {

        }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }

        public Square(int x, int y, int sideLength)
        {
            this.sideLength = sideLength;
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

