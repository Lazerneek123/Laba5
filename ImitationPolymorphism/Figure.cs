using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImitationPolymorphism
{
    public abstract class Figure
    {
        public Color ColorFigure { get; set; }

        public int x;
        public int y;

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public int MoveRight()
        {
            return 10;
        }
    }
}



