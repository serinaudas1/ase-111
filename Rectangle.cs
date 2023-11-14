using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    ///<summary>
    ///Shape interface of rectangles for drawing methods.
    ///</summary>
    ///<param name="width">width of rectangle</param>
    ///<param name="heigh">height of rectangle</param>
    internal class Rectangle : Shapes
    {
        int height;
        int width;

        public Rectangle() : base()
        {
            width = 100;
            height = 100;
        }
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public override double calcArea()
        {
            return width * height;
        }

        public override double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }

        public override void draw(Canvas g)
        {
            g.DrawRectangle(height, width);
        }

    }
}