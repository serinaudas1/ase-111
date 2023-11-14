using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ase_111
{
    public class Method
    {
        public string Name;
        public string[] Lines;

        public Method(string name, string[] lines)
        {
            Name = name;
            Lines = lines;
        }
    }
}
