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
            context = new Context();
            StartParsing();
        }

        private ITree tree;
        private Context context;

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
        private void Parsing(VarInitNode node)
        {
            if (!context.IsContainsGlobalVar(node.VarName))
            {
                context.AddGlobalVar(node.VarName, GetVarType(node.VarType));
            }
            else
            {
                Console.WriteLine("Переменная с именем {0} уже существует. Строка {1}", node.VarName, node.Line);
            }
        }
        private void Parsing(VarInitNode node, string methodName)
        {
            if (!context.IsContainsGlobalVar(node.VarName))
            {
                if (!context.IsContainsLocalVar(node.VarName, methodName))
                {
                    context.AddLocalVar(methodName, node.VarName, GetVarType(node.VarType));
                    dynamic temp = node.GetChild(1);
                    if (node.GetChild(1).ChildCount > 1)
                    {
                        Parsing(temp, GetVarType(node.VarType), methodName); // AssignNode
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
        private void Parsing(MethodDefNode node)
        {
            if (!context.IsContainsMethod(node.MethodName))
            {
                if (node.MethodType != null && GetMethodType(node.MethodType) != VarType.Undefined)
                {
                    context.AddMethod(node.MethodName, GetMethodType(node.MethodType));
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
            Parsing(node.VarInitNode, methodName);
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
                dynamic temp = node.GetChild(1);
                var right = Parsing(temp, methodName);

                if ((left == VarType.Int && right == VarType.Double) || right == VarType.Void)
                {
                    Console.WriteLine("Несоответствие типов. {0} нельзя привести к {1}. Строка {2}", left, right, node.Line);
                }
            }
        }
        private void Parsing(AssignNode node, string methodName)
        {
            VarType left = context.SearchVar(node.VarName, methodName);
            Parsing(node, left, methodName);
        }
        private VarType Parsing(IDNode node, string methodName)
        {
            if (!context.IsContainsGlobalVar(node.VarName))
            {
                if (!context.IsContainsLocalVar(node.VarName, methodName))
                {
                    Console.WriteLine("Переменная {0} не существует в текущем контексте. Строка {1}", node.VarName, node.Line);
                }
                else
                {
                    return context.GetTypeLocalVar(node.VarName, methodName);
                }
            }
            else
            {
                return context.GetTypeGlobalVar(node.VarName);
            }

            return VarType.Undefined;
        }
        private VarType Parsing(IntegerNode node, string methodName)
        {
            return VarType.Int;
        }
        private VarType Parsing(PlusNode node, string methodName)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(MinusNode node, string methodName)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(MultNode node, string methodName)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(DivideNode node, string methodName)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(CallMethodNode node, string methodName)
        {
            if (context.IsContainsMethod(node.MethodName))
            {
                return context.GetTypeMethod(node.MethodName);
            }
            else
            {
                Console.WriteLine("{0} не существует в текущем контексте. Строка {1}", node.MethodName, node.Line);
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
        private VarType ParseElementaryOperation(ITree node)
        {
            var left = GetVarType(node.GetChild(0).Text);
            var right = GetVarType(node.GetChild(1).Text);

            return (left == VarType.Double || right == VarType.Double) ? VarType.Double : VarType.Int;
        }
        private void CheckExistVars(CommonTree node, string methodName)
        {
            dynamic left = node.GetChild(0);
            dynamic right = node.GetChild(1);
            if (left is IDNode)
            {
                var temp = left as IDNode;
                VarType type = context.SearchVar(temp.GetChild(0).Text, methodName);
                if (type == VarType.Undefined)
                {
                    Console.WriteLine("Использование неопределенной переменной {0}. Строка {1}", temp.VarName, node.Line);
                }
            }

            if (right is IDNode)
            {
                var temp = right as IDNode;
                VarType type = context.SearchVar(temp.GetChild(0).Text, methodName);
                if (type == VarType.Undefined)
                {
                    Console.WriteLine("Использование неопределенной переменной {0}. Строка {1}", temp.VarName, node.Line);
                }
            }
        }
    }
}
