using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ase_111
{
    internal class ShapeFactory
    {
        ///<summary>
        ///The shape factory class which allows for the easy creation of and drawing of shapes with the program by getting shapes.
        ///</summary>


        public Shapes getShape(String shapeType, Canvas canvas, RichTextBox errortext, params int[] args)
        {
            int x, y;
            bool isInt;

            shapeType = shapeType.ToUpper().Trim(); //yoi could argue that you want a specific word string to create an object but I'm allowing any case combination
            int intvar;

            /*
            // For loop to go through all the parameters entered
            for (int i = 0; i < args.Length; i++)
            {
                // Parses the paramters the user has entered as an integer value and returns true/false 
                isInt = int.TryParse(args[i], out intvar);
                // If the entered parameter was not an integer, an error message is returned
                if (!isInt)
                {
                    //ErrorMsgBox.Text = "Non-Numeric Data Type Entered";
                }

            }

            */

            Console.WriteLine(args[0]);

            ///<summary>
            ///The shape is circle
            ///</summary>
            ///<param name="radius">radius of circle</param>

            if (shapeType.Equals("CIRCLE"))
            {
                if (args.Length == 1)
                {
                    Circle myCircle = new Circle(args[0]);
                    myCircle.draw(canvas);
                    return myCircle;
                }
                else
                {
                    PrintError(errortext);
                    return null;
                }
            }
            ///<summary>
            ///The shape is rectangle
            ///</summary>
            ///<param name="width">width of rectangle</param>
            ///<param name="height">height of rectangle</param>
            else if (shapeType.Equals("RECTANGLE"))
            {
                if (args.Length == 2)
                {
                    Rectangle myRect = new Rectangle(args[0], args[1]);
                    myRect.draw(canvas);
                    return myRect;
                }
                else
                {
                    PrintError(errortext);
                    return null;
                }
            }
            ///<summary>
            ///The shape is square
            ///</summary>
            ///<param name="side">length of sides of square</param>
            else if (shapeType.Equals("SQUARE"))
            {
                if (args.Length == 1)
                {
                    Square mySq = new Square(args[0]);
                    mySq.draw(canvas);
                    return mySq;
                }
                else
                {
                    PrintError(errortext);
                    return null;
                }
            }
            ///<summary>
            ///The shape is triangle
            ///</summary>
            ///<param name="coordinates of x1,y1">Coordinates of 1st point of triangle</param>
            ///<param name="coordinates of x2,y2">Coordinates of 2nd point of triangle</param>
            else if (shapeType.Equals("TRIANGLE"))
            {
                if (args.Length == 4)
                {
                    Triangle myTri = new Triangle(args[0], args[1], args[2], args[3]);
                    myTri.draw(canvas);
                    return myTri;
                }
                else
                {
                    PrintError(errortext);
                    return null;
                }
            }
            else
            {
                //if we get here then what has been passed in is inkown so throw an appropriate exception
                //System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                //throw argEx;

                PrintError(errortext);
                return null;
            }


        }
        public void PrintError(RichTextBox textBox)
        {
            textBox.Text = "Shape Error";
        }
    }
}