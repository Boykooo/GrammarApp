using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    public class MethodList
    {
        public MethodList()
        {
            methods = new List<Method>();
        }

        private List<Method> methods;

        public void AddMethod(string name, VarType type)
        {
            methods.Add(new Method(name, type));
        }
        public void AddLocalVar(string methodName, string varName, VarType type)
        {
            methods.FirstOrDefault((x) => x.Name == methodName).AddLocalVar(varName, type);
        }
        public bool IsContains(string name)
        {
            return methods.FirstOrDefault((x) => x.Name == name) != null;
        }
        public bool IsContainsLocalVar(string varName, string methodName)
        {
            return methods.FirstOrDefault((x) => x.Name == methodName).IsContainsLocalVar(varName);
        }

        public VarType GetTypeMethod(string name)
        {
            return methods.FirstOrDefault((x) => x.Name == name).Type;
        }

        public VarType GetTypeLocalVar(string varName, string methodName)
        {
            return methods.FirstOrDefault((x) => x.Name == methodName).GetLocalVarType(varName);
        }
    }
}
