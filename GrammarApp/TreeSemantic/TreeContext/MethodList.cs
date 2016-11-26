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

        List<Method> methods;
            
        public void AddMethod(string name)
        {
            methods.Add(new Method(name));
        }

        public bool IsContains(string name)
        {
            var q = methods.FirstOrDefault((x) => x.Name == name);
            return methods.FirstOrDefault((x) => x.Name == name) != null;
        }
    }
}
