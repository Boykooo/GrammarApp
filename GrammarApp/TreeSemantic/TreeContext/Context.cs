using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    class Context
    {
        public Context()
        {
            globalCount = 0;
            varList = new VarList();
            methodList = new MethodList();
        }

        private VarList varList;
        private MethodList methodList;
        private int globalCount;

        public void AddVar(string name, VarLocation location)
        {
            varList.AddVar(name, ++globalCount, location);
        }

        public void AddMethod(string name)
        {
            methodList.AddMethod(name);
        }

        public void AddLocalVar(string methodName, string varName)
        {
            
        }

        public bool IsContainsMethod(string name)
        {
            var q = methodList.IsContains(name);
            return methodList.IsContains(name);
        }
    }
}
