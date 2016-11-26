using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    public class Var
    {
        public Var(string name, int number, VarLocation location)
        {
            Name = name;
            Number = number;
            Location = location;
        }

        public string Name
        {
            get;
        }
        public int Number
        {
            get;
        }
        public VarLocation Location
        {
            get;
        }
    }
}
