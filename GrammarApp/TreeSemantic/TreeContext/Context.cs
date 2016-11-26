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
            vars = new VarList();
            methodList = new MethodList();
        }

        private VarList vars;
        private MethodList methodList;
        private int globalCount;

        public void AddGlobalVar(string name)
        {
            vars.AddVar(name, globalCount++);
        }
        
        public void AddMethod(string name)
        {
            methodList.AddMethod(name);
        }
        public void AddLocalVar(string methodName, string varName)
        {
            methodList.AddLocalVar(methodName, varName);
        }

        public bool IsContainsMethod(string name)
        {
            return methodList.IsContains(name);
        }
        public bool IsContainsGlobalVar(string name)
        {
            return vars.IsContains(name);
        }
        public bool IsContainsLocalVar(string varName, string methodName)
        {
            return methodList.IsContainsLocalVar(varName, methodName);
        }
    }
}
