using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    public class Method
    {
        public Method(string name)
        {
            vars = new VarList();
            Name = name;
            localVar = 0;
        }

        private VarList vars;
        private int localVar;

        public string Name
        {
            get;
        }

        public void AddLocalVar(string name)
        {
            vars.AddVar(name, localVar++);
        }

        public bool IsContainsLocalVar(string name)
        {
            return vars.IsContains(name);
        }
    }
}
