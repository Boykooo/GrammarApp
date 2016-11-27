using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    public enum VarType
    {
        Int,
        Double,
        Float,
        Char,
        Void,
        Undefined
    }

    public class Var
    {
        public Var(string name, int number, VarType type)
        {
            Name = name;
            Number = number;
            Type = type;
        }

        public string Name
        {
            get;
        }
        public int Number
        {
            get;
        }

        public VarType Type
        {
            get;
        }
    }
}
