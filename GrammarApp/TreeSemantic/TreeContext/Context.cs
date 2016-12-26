using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.TreeSemantic.TreeContext
{
    public class Context
    {
        public Context()
        {
            globalCount = 0;
            Vars = new VarList();
            MethodList = new MethodList();
        }

        public VarList Vars { get; set; }
        public MethodList MethodList { get; set; }
        private int globalCount;

        public void AddGlobalVar(string name, VarType type)
        {
            Vars.AddVar(name, globalCount++, type);
        }
        public void AddGlobalVar(string name, int length, VarType type)
        {
            Vars.AddVar(name, globalCount++, length, type);
        }

        public void AddMethod(string name, VarType type)
        {
            MethodList.AddMethod(name, type);
        }
        public void AddLocalVar(string methodName, string varName, VarType type)
        {
            MethodList.AddLocalVar(methodName, varName, type);
        }

        public void AddLocalVar(string methodName, string varName, int length, VarType type)
        {
            MethodList.AddLocalVar(methodName, varName, length, type);
        }

        public bool IsContainsMethod(string name)
        {
            return MethodList.IsContains(name);
        }
        public bool IsContainsGlobalVar(string name)
        {
            return Vars.IsContains(name);
        }
        public bool IsContainsLocalVar(string varName, string methodName)
        {
            return MethodList.IsContainsLocalVar(varName, methodName);
        }

        public VarType GetTypeMethod(string name)
        {
            return MethodList.GetTypeMethod(name);
        }
        public VarType GetTypeGlobalVar(string varName)
        {
            return Vars.GetTypeVar(varName);
        }

        public VarType GetTypeLocalVar(string varName, string methodName)
        {
            return MethodList.GetTypeLocalVar(varName, methodName);
        }
        public VarType SearchVar(string varName, string methodName)
        {
            if (Vars.IsContains(varName))
            {
                return Vars.GetTypeVar(varName);
            }
            else
            {
                if (MethodList.IsContainsLocalVar(varName, methodName))
                {
                    return MethodList.GetTypeLocalVar(varName, methodName);
                }
            }

            return VarType.Undefined;
        }


        public int GetID(string varName)
        {
            return Vars.GetVar(varName).Number;
        }

        public int GetID(string varName, string methodName)
        {
            Var temp = MethodList.GetLocalVar(methodName, varName);

            return (temp != null) ? temp.Number : -1;
        }
    }
}
