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
        IntArray,
        DoubleArray,
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

        public Var(string name, int number, VarType type, int length)
        {
            Name = name;
            Number = number;
            Type = type;
            Length = length;
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

        public int Length
        {
            get;
        }
    }
}
