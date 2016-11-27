using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace GrammarApp
{
    public class IntegerNode : CommonTree
    {
        public IntegerNode()
        {

        }
        public IntegerNode(CommonTree common) : base(common)
        {

        }
        public IntegerNode(IToken token) : base(token)
        {

        }
        public IntegerNode(int t)
            : base(new CommonToken(t, "IntegerNode"))
        {

        }

        public override ITree DupNode()
        {
            return new AssignNode(Type);
        }
    }
    public class DoubleNode : CommonTree
    {
        public DoubleNode()
        {

        }
        public DoubleNode(CommonTree common) : base(common)
        {

        }
        public DoubleNode(IToken token) : base(token)
        {

        }
        public DoubleNode(int t)
            : base(new CommonToken(t, "DoubleNode"))
        {

        }

        public override ITree DupNode()
        {
            return new AssignNode(Type);
        }
    }
    public class AssignNode : CommonTree
    {
        public AssignNode()
        {

        }
        public AssignNode(CommonTree common) : base(common)
        {

        }
        public AssignNode(IToken token) : base(token)
        {

        }
        public AssignNode(int t)
            : base(new CommonToken(t, "AssignNode"))
        {

        }

        public override ITree DupNode()
        {
            return new AssignNode(Type);
        }

    }
    public class PlusNode : CommonTree
    {
        public PlusNode()
        {

        }
        public PlusNode(CommonTree common) : base(common)
        {

        }
        public PlusNode(IToken token) : base(token)
        {

        }
        public PlusNode(int t)
            : base(new CommonToken(t, "PlusNode"))
        {

        }

        public override ITree DupNode()
        {
            return new PlusNode(Type);
        }
    }
    public class MinusNode : CommonTree
    {
        public MinusNode()
        {

        }
        public MinusNode(CommonTree common) : base(common)
        {

        }
        public MinusNode(IToken token) : base(token)
        {

        }
        public MinusNode(int t)
            : base(new CommonToken(t, "MinusNode"))
        {

        }

        public override ITree DupNode()
        {
            return new MinusNode(Type);
        }
    }
    public class MultNode : CommonTree
    {
        public MultNode()
        {

        }
        public MultNode(CommonTree common) : base(common)
        {

        }
        public MultNode(IToken token) : base(token)
        {

        }
        public MultNode(int t)
            : base(new CommonToken(t, "MultNode"))
        {

        }

        public override ITree DupNode()
        {
            return new MultNode(Type);
        }
    }
    public class DivideNode : CommonTree
    {
        public DivideNode()
        {

        }
        public DivideNode(CommonTree common) : base(common)
        {

        }
        public DivideNode(IToken token) : base(token)
        {

        }
        public DivideNode(int t)
            : base(new CommonToken(t, "DevideNode"))
        {

        }

        public override ITree DupNode()
        {
            return new DivideNode(Type);
        }
    }
    public class VarInitNode : CommonTree
    {

        public VarInitNode()
        {

        }
        public VarInitNode(CommonTree common) : base(common)
        {

        }
        public VarInitNode(IToken token) : base(token)
        {

        }
        public VarInitNode(int t)
            : base(new CommonToken(t, "VarInit"))
        {

        }

        public string VarType { get { return GetChild(0).Text; } }
        public string VarName { get { return GetChild(1).GetChild(0).Text; } }
    }
    public class ExprNode : CommonTree
    {
        public ExprNode()
        {

        }
        public ExprNode(CommonTree node) : base(node)
        {

        }
        public ExprNode(IToken t) : base(t)
        {

        }
        public ExprNode(int t) : base(new CommonToken(t, "ExprNode"))
        {

        }

        public override ITree DupNode()
        {
            return new ExprNode(Type);
        }
    }
    public class CodeBlockNode : CommonTree
    {
        public CodeBlockNode()
        {

        }
        public CodeBlockNode(CommonTree node)
            : base(node)
        {

        }
        public CodeBlockNode(IToken t)
            : base(t)
        {

        }
        public CodeBlockNode(int t)
            : base(new CommonToken(t, "CodeBlockNode"))
        {

        }

        public override ITree DupNode()
        {
            return new CodeBlockNode(Type);
        }
    }
    public class MethodDefNode : CommonTree
    {
        public MethodDefNode()
        {

        }
        public MethodDefNode(CommonTree node) : base(node)
        {

        }
        public MethodDefNode(IToken t) : base(t)
        {

        }
        public MethodDefNode(int t) : base(new CommonToken(t, "MethodDefNode"))
        {

        }

        public string MethodName { get { return GetChild(0).Text; } }
        public string MethodType { get { return GetChild(0).GetChild(0).Text; } }
        public CodeBlockNode Block { get { return GetChild(0).GetChild(1) as CodeBlockNode; } }
    }
    public class CallMethodNode : CommonTree
    {
        public CallMethodNode()
        {

        }
        public CallMethodNode(CommonTree node) : base(node)
        {

        }
        public CallMethodNode(IToken t) : base(t)
        {

        }
        public CallMethodNode(int t) : base(new CommonToken(t, "CallMethodNode"))
        {

        }

        public string MethodName { get { return GetChild(0).Text; } }
    }

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
        public ForNode(int t)
            : base(new CommonToken(t, "ForNode"))
        {

        }
    }
}
