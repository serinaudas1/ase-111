using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    ///<summary>
    ///Shape interface of triangles for drawing methods.
    ///</summary>
    ///<param name="coordinates of x1,y1">Coordinates of 1st point of triangle</param>
    ///<param name="coordinates of x2,y2">Coordinates of 2nd point of triangle</param>
    internal class Triangle : Shapes
    {



        int x1, y1, x2, y2;
        public Triangle() : base() { }
        public Triangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

        }

        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void draw(Canvas g)
        {
            g.DrawTriangle(x1, y1, x2, y2);
        }
    }
}

