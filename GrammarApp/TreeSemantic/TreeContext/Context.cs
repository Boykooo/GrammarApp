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

        public void AddGlobalVar(string name, VarType type)
        {
            vars.AddVar(name, globalCount++, type);
        }
        public void AddGlobalVar(string name, int length, VarType type)
        {
            vars.AddVar(name, globalCount++, length, type);
        }

        public void AddMethod(string name, VarType type)
        {
            methodList.AddMethod(name, type);
        }
        public void AddLocalVar(string methodName, string varName, VarType type)
        {
            methodList.AddLocalVar(methodName, varName, type);
        }

        public void AddLocalVar(string methodName, string varName, int length, VarType type)
        {
            methodList.AddLocalVar(methodName, varName, length, type);
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

        public VarType GetTypeMethod(string name)
        {
            return methodList.GetTypeMethod(name);
        }
        public VarType GetTypeGlobalVar(string varName)
        {
            return vars.GetTypeVar(varName);
        }

        public VarType GetTypeLocalVar(string varName, string methodName)
        {
            return methodList.GetTypeLocalVar(varName, methodName);
        }
        public VarType SearchVar(string varName, string methodName)
        {
            if (vars.IsContains(varName))
            {
                return vars.GetTypeVar(varName);
            }
            else
            {
                if (methodList.IsContainsLocalVar(varName, methodName))
                {
                    return methodList.GetTypeLocalVar(varName, methodName);
                }
            }

            return VarType.Undefined;
        }
    }
}
