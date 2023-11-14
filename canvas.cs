using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{

    internal class Canvas
    {




        //<summary>
        //Initializing Objects/Variables
        //</summary>

        Graphics g;

        Pen pen;

        Brush brush;

        int xPos, yPos;

        public bool Fill = false;



        //<summary>
        //this.g refers to the local variable
        //initiazling pen position to 0,0 in bitmap
        //</summary>

        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1);
            brush = new SolidBrush(Color.Black);
        }


        //<summary>
        // Method to reset pen position to 0,0
        //</summary>

        public void Reset(int toX, int toY)
        {
            xPos = 0;
            yPos = 0;

        }

        //<summary>
        // Method to Change pen color to Red, Green, Blue or Black
        //</summary>

        public void PenColor(String pencolor)
        {
            if (pencolor == "red")
            {
                pen.Color = Color.Red;
            }
            else if (pencolor == "blue")
            {
                pen.Color = Color.Blue;
            }
            else if (pencolor == "green")
            {
                pen.Color = Color.Green;
            }
            else if (pencolor == "black")
            {
                pen.Color = Color.Black;
            }
        }


        //<summary>
        // Method to Clear the drawn objects as well as error messages
        //</summary>


        public void Clear()
        {
            g.Clear(Color.White);
        }

        //<summary>
        // Method to draw a line to a specified coordinate on the bitmap
        //</summary>


        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }

        //<summary>
        // Method to move the pen location to specified coordinate on the bitmap
        //</summary>

        public void MoveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }
        //<summary>
        // Method to draw a square of specified dimension
        //</summary>

        public void DrawSquare(int width)
        {
            g.DrawRectangle(pen, xPos, yPos, xPos + width, yPos + width);
            if (Fill)
                g.FillRectangle(brush, xPos, yPos, xPos + width, yPos + width);
        }

        //<summary>
        // Method to draw a circle of specified dimension using ellipses
        //</summary>

        public void DrawCircle(int radius)
        {

            g.DrawEllipse(pen, xPos, yPos, xPos + (radius * 2), yPos + (radius * 2));
            if (Fill)
                g.FillEllipse(brush, xPos, yPos, xPos + (radius * 2), yPos + (radius * 2));

        }
        //<summary>
        // Method to draw a rectangle of specified dimensions
        //</summary>
        public void DrawRectangle(int length, int width)
        {
            g.DrawRectangle(pen, xPos, yPos, xPos + length, yPos + width);
            if (Fill)
                g.FillRectangle(brush, xPos, yPos, xPos + length, yPos + width);

        }
        //<summary>
        // Method to draw a triangle by specifying end point of the first two lines and making last line go back to origin point
        // Might change formula using sides by doing the Math method using (x2-x1)^2 + (y2-y1)^2 formulas etc.
        //</summary>
        public void DrawTriangle(int x1, int y1, int x2, int y2)
        {
            int xoriginal = xPos;
            int yoriginal = yPos;

            g.DrawLine(pen, xPos, yPos, x1, y1);

            xPos = x1;
            yPos = y1;

            g.DrawLine(pen, xPos, yPos, x2, y2);
            xPos = x2;
            yPos = y2;

            g.DrawLine(pen, xPos, yPos, xoriginal, yoriginal);
            xPos = xoriginal;
            yPos = yoriginal;



            if (Fill)
            {
                //g.FillPolygon(brush, PointF[] points)
            }

        }




    }
}
