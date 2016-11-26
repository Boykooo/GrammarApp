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

        }

        private List<Var> vars;

        public void AddVar(string name, int number, VarLocation location)
        {
            vars.Add(new Var(name, number, location));
        }

        public Var GetVar(string name)
        {
            return vars.FirstOrDefault((x) => x.Name == name);
        }

        public bool IsContains(string name, VarLocation location)
        {
            return vars.Exists((x) => x.Name == name && x.Location == location);
        }
    }
}
