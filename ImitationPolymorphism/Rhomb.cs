using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImitationPolymorphism
{
    public class Rhomb : Figure
    {
        private int horDiagLen;
        public int HorDiagLen
        {
            get
            {
                return horDiagLen;
            }
            set
            {
                horDiagLen = HorDiagLen;
            }
        }

        private int vertDiagLen;
        public int VertDiagLen
        {
            get
            {
                return vertDiagLen;
            }
            set
            {
                vertDiagLen = VertDiagLen;
            }
        }

        private int x2;
        public int X2
        {
            get
            {
                return x2;
            }
            set
            {
                x2 = value;
            }
        }
        
        private int y2;
        public int Y2
        {
            get
            {
                return y2;
            }
            set
            {
                y2 = value;
            }
        }

        private int x3;
        public int X3
        {
            get
            {
                return x3;
            }
            set
            {
                x3 = value;
            }
        }

        private int y3;
        public int Y3
        {
            get
            {
                return y3;
            }
            set
            {
                y3 = value;
            }
        }

        public Rhomb()
        {

        }

        public Rhomb(int horDiagLen, int vertDiagLen)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }

        public Rhomb(int x, int y, int horDiagLen, int vertDiagLen)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
            this.x = x;
            this.y = y;
        }

        public Rhomb(int x, int y, int x2, int y2, int x3, int y3)
        {            
            this.x = x;
            this.y = y;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;

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

