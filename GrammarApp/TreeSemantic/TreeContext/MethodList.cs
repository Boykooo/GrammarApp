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

        public void AddMethod(string name)
        {
            methods.Add(new Method(name));
        }
        public void AddLocalVar(string methodName, string varName)
        {
            methods.FirstOrDefault((x) => x.Name == methodName).AddLocalVar(varName);
        }
        public bool IsContains(string name)
        {
            return methods.FirstOrDefault((x) => x.Name == name) != null;
        }
        public bool IsContainsLocalVar(string varName, string methodName)
        {
            return methods.FirstOrDefault((x) => x.Name == methodName).IsContainsLocalVar(varName);
        }

    }
}
