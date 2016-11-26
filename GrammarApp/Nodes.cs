using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp
{
    public class ForNode : CommonTree
    {
        public ForNode()
        {

        }
        public ForNode(CommonTree common) : base(common)
        {

        }
        public ForNode(IToken token) : base(token)
        {

        }
    }

    public class VarInit : CommonTree
    {

        public VarInit()
        {

        }
        public VarInit(CommonTree common) : base(common)
        {

        }
        public VarInit(IToken token) : base(token)
        {

        }
        public VarInit(int t)
            : base(new CommonToken(t, "VarInit"))
        {

        }

        public string VarType { get { return GetChild(0).Text; } }
        public int VarCount { get { return ChildCount - 1; } }
    }

    public class MethodDef : CommonTree
    {
        public MethodDef()
        {

        }
        public MethodDef(CommonTree node) : base(node)
        {

        }
        public MethodDef(IToken t) : base(t)
        {

        }
        public MethodDef(int t) : base(new CommonToken(t, "MethodDef"))
        {

        }

        public string MethodName { get { return GetChild(0).Text; } }
        public string MethodType { get { return GetChild(0).GetChild(0).Text; } }
        public CodeBlock Block { get { return GetChild(0).GetChild(1) as CodeBlock; } }
    }
    public class CodeBlock : CommonTree
    {
        public CodeBlock()
        {

        }
        public CodeBlock(CommonTree node)
            : base(node)
        {

        }
        public CodeBlock(IToken t)
            : base(t)
        {

        }
        public CodeBlock(int t)
            : base(new CommonToken(t, "CodeBlock"))
        {

        }

        public override ITree DupNode()
        {
            return new CodeBlock(Type);
        }
    }
}
