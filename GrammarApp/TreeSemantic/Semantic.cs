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
                context.AddGlobalVar(node.VarName);
            }
            else
            {
                Console.WriteLine("Переменная с таким именем уже существует. Строка {0}", node.Line);
            }
        }
        private void Parsing(VarInitNode node, string methodName)
        {
            if (!context.IsContainsGlobalVar(node.VarName))
            {
                if (!context.IsContainsLocalVar(node.VarName, methodName))
                {
                    context.AddLocalVar(methodName, node.VarName);
                    dynamic temp = node.GetChild(1);
                    if (node.GetChild(1).ChildCount > 1)
                    {
                        Parsing(temp, GetVarType(node.VarType));
                    }

                }
                else
                {
                    Console.WriteLine("Уже существует локальная переменная с таким же именем. Строка {0}", node.Line);
                }
            }
            else
            {
                Console.WriteLine("Уже существует глобальная переменная с таким же именем. Строка {0}", node.Line);
            }

        }
        private void Parsing(MethodDefNode node)
        {
            if (!context.IsContainsMethod(node.MethodName))
            {
                if (node.MethodType != null && GetMethodType(node.MethodType) != VarType.Undefined)
                {
                    context.AddMethod(node.MethodName, GetVarType(node.MethodType));
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
        private void Parsing(AssignNode node, VarType left)
        {
            var q = node.GetChild(1);
            if (node.GetChild(1).Type == 0)
            {
                Console.WriteLine("Некорректная инициализация переменной. Строка {0}", node.Line);
            }
            else
            {
                dynamic temp = node.GetChild(1);
                var right = Parsing(temp);

                if (left == VarType.Int && right == VarType.Double)
                {
                    Console.WriteLine("Несоответствие типов. {0} нельзя привести к {1}. Строка {2}", left, right, node.Line);
                }
            }
        }

        private VarType Parsing(PlusNode node)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(MinusNode node)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(MultNode node)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(DivideNode node)
        {
            return ParseElementaryOperation(node);
        }
        private VarType Parsing(CallMethodNode node)
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
                if (tmp is VarInitNode)
                {
                    Parsing(tmp, methodName);
                }
                else
                {
                    Parsing(tmp);
                }
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
    }
}
