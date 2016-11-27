using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace GrammarApp
{
    public class IDNode : CommonTree
    {
        public IDNode()
        {

        }
        public IDNode(CommonTree common) : base(common)
        {

        }
        public IDNode(IToken token) : base(token)
        {

        }
        public IDNode(int t)
            : base(new CommonToken(t, "IDNode"))
        {

        }

        public string VarName { get { return GetChild(0).Text; } }

        public override ITree DupNode()
        {
            return new AssignNode(Type);
        }
    }
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

        public string VarName { get { return GetChild(0).GetChild(0).Text; } }

    }
    public class IncNode : CommonTree
    {
        public IncNode()
        {

        }
        public IncNode(CommonTree common) : base(common)
        {

        }
        public IncNode(IToken token) : base(token)
        {

        }
        public IncNode(int t)
            : base(new CommonToken(t, "IncNode"))
        {

        }

        public override ITree DupNode()
        {
            return new IncNode(Type);
        }
    }
    public class DecNode : CommonTree
    {
        public DecNode()
        {

        }
        public DecNode(CommonTree common) : base(common)
        {

        }
        public DecNode(IToken token) : base(token)
        {

        }
        public DecNode(int t)
            : base(new CommonToken(t, "DecNode"))
        {

        }

        public override ITree DupNode()
        {
            return new DecNode(Type);
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
        public string VarName { get { return GetChild(1).GetChild(0).GetChild(0).Text; } }
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

    public class IfNode : CommonTree
    {
        public IfNode()
        {

        }
        public IfNode(CommonTree common) : base(common)
        {

        }
        public IfNode(IToken token) : base(token)
        {

        }
        public IfNode(int t)
            : base(new CommonToken(t, "IfNode"))
        {

        }

        public CodeBlockNode Block { get { return GetChild(1) as CodeBlockNode; } }
        public override ITree DupNode()
        {
            return new IfNode(Type);
        }
    }
    public class LogicOperation : CommonTree
    {
        public LogicOperation()
        {

        }
        public LogicOperation(CommonTree common) : base(common)
        {

        }
        public LogicOperation(IToken token) : base(token)
        {

        }
        public LogicOperation(int t)
            : base(new CommonToken(t, "LogicOperation"))
        {

        }

        public override ITree DupNode()
        {
            return new LogicOperation(Type);
        }
    }
    public class OrOperationNode : CommonTree
    {
        public OrOperationNode()
        {

        }
        public OrOperationNode(CommonTree common) : base(common)
        {

        }
        public OrOperationNode(IToken token) : base(token)
        {

        }
        public OrOperationNode(int t)
            : base(new CommonToken(t, "OrOperation"))
        {

        }

        public override ITree DupNode()
        {
            return new OrOperationNode(Type);
        }
    }
    public class AndOperationNode : CommonTree
    {
        public AndOperationNode()
        {

        }
        public AndOperationNode(CommonTree common) : base(common)
        {

        }
        public AndOperationNode(IToken token) : base(token)
        {

        }
        public AndOperationNode(int t)
            : base(new CommonToken(t, "AndOperationNode"))
        {

        }

        public override ITree DupNode()
        {
            return new AndOperationNode(Type);
        }
    }
    public class EqualityOperationNode : CommonTree
    {
        public EqualityOperationNode()
        {

        }
        public EqualityOperationNode(CommonTree common) : base(common)
        {

        }
        public EqualityOperationNode(IToken token) : base(token)
        {

        }
        public EqualityOperationNode(int t)
            : base(new CommonToken(t, "EqualityOperationNode"))
        {

        }

        public override ITree DupNode()
        {
            return new EqualityOperationNode(Type);
        }
    }
    public class NonEqualityOperationNode : CommonTree
    {
        public NonEqualityOperationNode()
        {

        }
        public NonEqualityOperationNode(CommonTree common) : base(common)
        {

        }
        public NonEqualityOperationNode(IToken token) : base(token)
        {

        }
        public NonEqualityOperationNode(int t)
            : base(new CommonToken(t, "NonEqualityOperationNode"))
        {

        }

        public override ITree DupNode()
        {
            return new NonEqualityOperationNode(Type);
        }
    }
    public class LogicOperationMoreNode : CommonTree
    {
        public LogicOperationMoreNode()
        {

        }
        public LogicOperationMoreNode(CommonTree common) : base(common)
        {

        }
        public LogicOperationMoreNode(IToken token) : base(token)
        {

        }
        public LogicOperationMoreNode(int t)
            : base(new CommonToken(t, "LogicOperationMoreNode"))
        {

        }

        public override ITree DupNode()
        {
            return new LogicOperationMoreNode(Type);
        }
    }
    public class LogicOperationMoreEqNode : CommonTree
    {
        public LogicOperationMoreEqNode()
        {

        }
        public LogicOperationMoreEqNode(CommonTree common) : base(common)
        {

        }
        public LogicOperationMoreEqNode(IToken token) : base(token)
        {

        }
        public LogicOperationMoreEqNode(int t)
            : base(new CommonToken(t, "LogicOperationMoreEqNode"))
        {

        }

        public override ITree DupNode()
        {
            return new LogicOperationMoreEqNode(Type);
        }
    }
    public class LogicOperationLessNode : CommonTree
    {
        public LogicOperationLessNode()
        {

        }
        public LogicOperationLessNode(CommonTree common) : base(common)
        {

        }
        public LogicOperationLessNode(IToken token) : base(token)
        {

        }
        public LogicOperationLessNode(int t)
            : base(new CommonToken(t, "LogicOperationLessNode"))
        {

        }

        public override ITree DupNode()
        {
            return new LogicOperationLessNode(Type);
        }
    }
    public class LogicOperationLessEqNode : CommonTree
    {
        public LogicOperationLessEqNode()
        {

        }
        public LogicOperationLessEqNode(CommonTree common) : base(common)
        {

        }
        public LogicOperationLessEqNode(IToken token) : base(token)
        {

        }
        public LogicOperationLessEqNode(int t)
            : base(new CommonToken(t, "LogicOperationLessEqNode"))
        {

        }

        public override ITree DupNode()
        {
            return new LogicOperationLessEqNode(Type);
        }
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

        public VarInitNode VarInitNode { get { return GetChild(0) as VarInitNode; } }
        public AssignNode VarInitValue { get { return GetChild(2) as AssignNode; } }
        public CodeBlockNode Block { get { return GetChild(3) as CodeBlockNode; } }
    }
    public class WhileNode : CommonTree
    {
        public WhileNode()
        {

        }
        public WhileNode(CommonTree common) : base(common)
        {

        }
        public WhileNode(IToken token) : base(token)
        {

        }
        public WhileNode(int t)
            : base(new CommonToken(t, "While"))
        {

        }

        public CodeBlockNode Block { get { return GetChild(1) as CodeBlockNode; } }
    }

}
