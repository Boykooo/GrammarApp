using Antlr.Runtime;
using Antlr.Runtime.Tree;
using GrammarApp.TreeSemantic.TreeContext;
using System;

namespace GrammarApp.TreeSemantic
{
    public class Semantic
    {
        public Semantic(ITree tree)
        {
            this.tree = tree;
            Context = new Context();
            StartParsing();
        }

        private ITree tree;
        public Context Context { get; set; }

        private void StartParsing()
        {
            for (int i = 0; i < tree.ChildCount; i++)
            {
                dynamic tmp = tree.GetChild(i);
                Parsing(tmp);
            }
        }

        private void Parsing(CommonTree tree)
        {

        }
        private void Parsing(CommonTree tree, string methodName)
        {

        }

        private void Parsing(VarInitNode node)
        {
            if (!Context.IsContainsGlobalVar(node.VarName))
            {
                Context.AddGlobalVar(node.VarName, GetVarType(node.VarType));

                AddID(node.ID);
            }
            else
            {
                Console.WriteLine("Переменная с именем {0} уже существует. Строка {1}", node.VarName, node.Line);
            }
        }
        private void Parsing(VarInitNode node, string methodName)
        {
            if (!Context.IsContainsGlobalVar(node.VarName))
            {
                if (!Context.IsContainsLocalVar(node.VarName, methodName))
                {
                    Context.AddLocalVar(methodName, node.VarName, GetVarType(node.VarType));
                    

                    dynamic temp = node.GetChild(1);
                    if (node.GetChild(1).ChildCount > 1)
                    {
                        Parsing(temp, GetVarType(node.VarType), methodName); // AssignNode
                    }
                    else
                    {
                        AddID(node.ID, methodName);
                    }

                }
                else
                {
                    Console.WriteLine("Уже существует локальная переменная с именем {0}. Строка {1}", node.VarName, node.Line);
                }
            }
            else
            {
                Console.WriteLine("Уже существует глобальная переменная с именем {0}. Строка {1}", node.VarName, node.Line);
            }

        }

        private void Parsing(ArrayDeclNode node)
        {
            if (!Context.IsContainsGlobalVar(node.Name))
            {
                Context.AddGlobalVar(node.Name, node.Length, GetVarType(node.GetChild(0).Text));
                AddID(node.ID);
            }
            else
            {
                Console.WriteLine("Массив с именем {0} уже существует. Строка {1}", node.Name, node.Line);
            }
        }
        private void Parsing(ArrayDeclNode node, string methodName)
        {
            if (!Context.IsContainsGlobalVar(node.Name) && !Context.IsContainsLocalVar(node.Name, methodName))
            {
                Context.AddLocalVar(methodName, node.Name, node.Length, GetVarType(node.GetChild(0).Text));
                AddID(node.ID, methodName);
            }
            else
            {
                Console.WriteLine("Массив с именем {0} уже существует. Строка {1}", node.Name, node.Line);
            }
        }
        private void Parsing(ArrayInitNode node)
        {
            Console.WriteLine("Check initialization array");
        }
        private void Parsing(ArrayInitNode node, string methodName)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                Parsing(node.GetChild(i) as dynamic, methodName);
            }
        }


        private void Parsing(MethodDefNode node)
        {
            if (!Context.IsContainsMethod(node.MethodName))
            {
                if (node.MethodType != null && GetMethodType(node.MethodType) != VarType.Undefined)
                {
                    Context.AddMethod(node.MethodName, GetMethodType(node.MethodType));
                }
                else
                {
                    Console.WriteLine("Некорректный тип возвращаемого значения. Строка {0}", node.Line);
                }
            }
            else
            {
                Console.WriteLine("Метод с именем {0} уже существует. Строка {1}", node.MethodName, node.Line);
            }

            Parsing(node.Block, node.MethodName);
        }
        private void Parsing(ForNode node, string methodName)
        {
            Parsing(node.GetChild(0) as dynamic, methodName);
            dynamic temp = node.GetChild(1); // Logic operation
            Parsing(temp, methodName);
            Parsing(node.VarInitValue, methodName);
            Parsing(node.Block, methodName);
        }
        private void Parsing(WhileNode node, string methodName)
        {
            dynamic temp = node.GetChild(0); // Logic operation
            Parsing(temp, methodName);
            Parsing(node.Block, methodName);
        }

        private void Parsing(IfNode node, string methodName)
        {
            dynamic temp = node.GetChild(0); // Logic operation
            Parsing(temp, methodName);
            Parsing(node.Block, methodName);
        }
        private void Parsing(LogicOperation node, string methodName)
        {

        }
        private void Parsing(OrOperationNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(AndOperationNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(EqualityOperationNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(NonEqualityOperationNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(LogicOperationMoreNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(LogicOperationMoreEqNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(LogicOperationLessNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(LogicOperationLessEqNode node, string methodName)
        {
            CheckExistVars(node, methodName);
        }
        private void Parsing(AssignNode node, VarType left, string methodName)
        {
            if (node.GetChild(1).Type == 0)
            {
                Console.WriteLine("Некорректная инициализация переменной. Строка {0}", node.Line);
            }
            else
            {
                dynamic id = node.GetChild(0);
                if (id is ArrayInitNode)
                {
                    GetArrayType(id, methodName);
                    Parsing(id.GetChild(0) as dynamic, methodName);
                    Parsing(id.GetChild(1) as dynamic, methodName);
                }
                else
                {
                    Parsing(id, methodName);
                }

                dynamic temp = node.GetChild(1);

                var right = VarType.Undefined;

                if (temp is ArrayInitNode)
                {
                    right = GetArrayType(temp, methodName);
                    Parsing(temp.GetChild(0) as dynamic, methodName);
                    Parsing(temp.GetChild(1) as dynamic, methodName);
                }
                else
                {
                    right = Parsing(temp, methodName);
                }
                

                if ((left == VarType.Int && right == VarType.Double) || right == VarType.Void)
                {
                    Console.WriteLine("Несоответствие типов. {0} нельзя привести к {1}. Строка {2}", left, right, node.Line);
                }
            }
        }
        private void Parsing(AssignNode node, string methodName)
        {
            VarType left = Context.SearchVar(node.VarName, methodName);
            Parsing(node, left, methodName);
        }
        private VarType Parsing(IDNode node, string methodName)
        {
            if (!Context.IsContainsGlobalVar(node.VarName))
            {
                if (!Context.IsContainsLocalVar(node.VarName, methodName))
                {
                    Console.WriteLine("Переменная {0} не существует в текущем контексте. Строка {1}", node.VarName, node.Line);
                }
                else
                {
                    AddID(node, methodName);
                    return Context.GetTypeLocalVar(node.VarName, methodName);
                }
            }
            else
            {
                AddID(node);
                return Context.GetTypeGlobalVar(node.VarName);
            }

            return VarType.Undefined;
        }
        private VarType Parsing(IntegerNode node, string methodName)
        {
            return VarType.Int;
        }
        private VarType Parsing(PlusNode node, string methodName)
        {
            return ParseElementaryOperation(node, methodName);
        }
        private VarType Parsing(MinusNode node, string methodName)
        {
            return ParseElementaryOperation(node, methodName);
        }
        private VarType Parsing(MultNode node, string methodName)
        {
            return ParseElementaryOperation(node, methodName);
        }
        private VarType Parsing(DivideNode node, string methodName)
        {
            return ParseElementaryOperation(node, methodName);
        }
        private VarType Parsing(CallMethodNode node, string methodName)
        {
            if (Context.IsContainsMethod(node.MethodName))
            {
                return Context.GetTypeMethod(node.MethodName);
            }
            else
            {
                Console.WriteLine("{0} не существует в текущем контексте. Строка {1}", node.MethodName, node.Line);
            }

            return VarType.Undefined;

        }
        private VarType GetArrayType(ArrayInitNode node, string methodName)
        {
            if (Context.IsContainsLocalVar(node.ID.GetChild(0).Text, methodName))
            {
                return Context.GetTypeLocalVar(node.ID.GetChild(0).Text, methodName);
            }
            else
            {
                Console.WriteLine("{0} не существует в текущем контексте. Строка {1}", node.ID.GetChild(0), node.Line);
            }

            return VarType.Undefined;

        }


        private void Parsing(CodeBlockNode node, string methodName)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                dynamic tmp = node.GetChild(i);
                Parsing(tmp, methodName);
            }
        }

        private void Parsing(PrintNode node, string methodName)
        {
            Parsing(node.GetChild(0) as dynamic, methodName);
            //AddID((IDNode)node.GetChild(0), methodName);
        }

        private void Parsing(PrintlnNode node, string methodName)
        {
            Parsing(node.GetChild(0) as dynamic, methodName);
        }

        private void Parsing(NextLineNode node, string methodName)
        {

        }


        private void AddID(IDNode node)
        {
            ITree newNode = new CommonTree(new CommonToken(1, Context.GetID(node.VarName).ToString()));
            node.AddChild(newNode);
        }

        private void AddID(IDNode node, string methodName)
        {
            ITree newNode = new CommonTree(new CommonToken(1, Context.GetID(node.VarName, methodName).ToString()));
            node.AddChild(newNode);
        }


        private VarType GetVarType(string type)
        {
            switch (type)
            {
                case "int":
                    return VarType.Int;
                case "double":
                    return VarType.Double;
                case "IntegerNode":
                    return VarType.Int;
                case "DoubleNode":
                    return VarType.Double;
                case "char":
                    return VarType.Char;
                case "float":
                    return VarType.Float;
                default:
                    return VarType.Undefined;
            }
        }
        private VarType GetMethodType(string type)
        {
            return type == "void" ? VarType.Void : GetVarType(type);
        }
        private VarType ParseElementaryOperation(CommonTree node, string methodName)
        {

            dynamic leftNode = node.GetChild(0);
            var left = Parsing(leftNode, methodName);

            dynamic rightNode = node.GetChild(1);
            var right = Parsing(rightNode, methodName);

            return (left == VarType.Double || right == VarType.Double) ? VarType.Double : VarType.Int;
        }
        private void CheckExistVars(CommonTree node, string methodName)
        {
            dynamic left = node.GetChild(0);
            dynamic right = node.GetChild(1);
            if (left is IDNode)
            {
                var temp = left as IDNode;
                VarType type = Context.SearchVar(temp.GetChild(0).Text, methodName);
                if (type == VarType.Undefined)
                {
                    Console.WriteLine("Использование неопределенной переменной {0}. Строка {1}", temp.VarName, node.Line);
                }
                else
                {
                    AddID(temp, methodName);
                }
            }

            if (left is ArrayInitNode)
            {
                IDNode temp = left.GetChild(0);
                VarType type = Context.SearchVar(temp.GetChild(0).Text, methodName);
                if (type == VarType.Undefined)
                {
                    Console.WriteLine("Использование неопределенной переменной {0}. Строка {1}", temp.VarName, node.Line);
                }
                else
                {
                    AddID(temp, methodName);
                    Parsing(left.GetChild(1) as dynamic, methodName);
                }
            }

            if (right is IDNode)
            {
                var temp = right as IDNode;
                VarType type = Context.SearchVar(temp.GetChild(0).Text, methodName);
                if (type == VarType.Undefined)
                {
                    Console.WriteLine("Использование неопределенной переменной {0}. Строка {1}", temp.VarName, node.Line);
                }
                else
                {
                    AddID(temp, methodName);
                }

            }

            if (right is ArrayInitNode)
            {
                IDNode temp = right.GetChild(0);
                VarType type = Context.SearchVar(temp.GetChild(0).Text, methodName);
                if (type == VarType.Undefined)
                {
                    Console.WriteLine("Использование неопределенной переменной {0}. Строка {1}", temp.VarName, node.Line);
                }
                else
                {
                    AddID(temp, methodName);
                    Parsing(right.GetChild(1) as dynamic, methodName);
                }
            }
        }
    }
}
