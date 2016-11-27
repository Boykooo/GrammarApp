using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    public class VarList
    {
        public VarList()
        {
            vars = new List<Var>();
        }

        private List<Var> vars;

        public void AddVar(string name, int number, VarType type)
        {
            vars.Add(new Var(name, number, type));
        }
            
        public Var GetVar(string name)
        {
            return vars.FirstOrDefault((x) => x.Name == name);
        }

        public bool IsContains(string name)
        {
            return vars.Exists((x) => x.Name == name);
        }

        public VarType GetTypeVar(string name)
        {
            return vars.FirstOrDefault((x) => x.Name == name).Type;
        }
    }
}
