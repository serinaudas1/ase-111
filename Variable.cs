using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    ///<summary>
    ///Variables list storing name and value of each variable
    ///</summary>
    ///<param name="varName">Variable Name</param>
    ///<param name="varValue">Variable Value</param>
    public class Variable
    {
        public int value;
        public string name;

        public Variable(int value, string name)
        {
            this.value = value;
            this.name = name;
        }

        public override string ToString()
        {
            return "\nName: " + this.name + " Value: " + this.value;
        }

    }

}