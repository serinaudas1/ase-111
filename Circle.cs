using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    //<summary>
    //Shape interface of circles for drawing methods.
    //</summary>
    internal class Circle : Shapes
    {
        int radius;


        public Circle() : base()
        {

        }
        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {
            this.radius = radius; //the only thingthat is different from shape
        }

        public Circle(int radius)
        {
            this.radius = radius; //the only thingthat is different from shape


        }

        public override double calcArea()
        {
            return Math.PI * (radius ^ 2);
        }

        public override double calcPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void draw(Canvas g)
        {
            g.DrawCircle(radius);

        }

        public override string ToString()
        {
            return "Circle" + "Radius: " + radius;
        }

    }
}
