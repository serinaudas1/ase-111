using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    /// <summary>
    /// Shape interface class
    /// </summary>
    interface ShapeInterface
    {
        void set(Color c, params int[] list);
        void draw(Canvas g);
        double calcArea();
        double calcPerimeter();
    }
}
