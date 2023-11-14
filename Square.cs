using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    ///<summary>
    ///Shape interface of squares for drawing methods.
    ///</summary>
    ///<param name="side">length of each side of the square</param>
    internal class Square : Rectangle
    {

        private int size;
        public Square() : base()
        {

        }
        public Square(Color colour, int x, int y, int size) : base(colour, x, y, size, size)
        {
            this.size = size;
        }


        public Square(int size)
        {
            this.size = size;
        }

        public override double calcArea()
        {
            return size * size;
        }

        public override double calcPerimeter()
        {
            return size * 4;
        }

        public override void draw(Canvas g)
        {
            g.DrawSquare(size);
        }
    }
}
