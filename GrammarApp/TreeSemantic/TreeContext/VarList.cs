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
            Vars = new List<Var>();
        }

        public List<Var> Vars { get; set; }

        public void AddVar(string name, int number, VarType type)
        {
            Vars.Add(new Var(name, number, type));
        }

        public void AddVar(string name, int number, int length, VarType type)
        {
            Vars.Add(new Var(name, number, type, length));
        }

        public Var GetVar(string name)
        {
            return Vars.FirstOrDefault((x) => x.Name == name);
        }

        public bool IsContains(string name)
        {
            return Vars.Exists((x) => x.Name == name);
        }

        public VarType GetTypeVar(string name)
        {
            return Vars.FirstOrDefault((x) => x.Name == name).Type;
        }
    }
}
