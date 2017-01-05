using Antlr.Runtime.Tree;
using GrammarApp.TreeSemantic.TreeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp.linker
{
    public class Codegenerator
    {

        private VarList globalVars;


        public Codegenerator()
        {
        }
        public string Start(CommonTree root, MethodList methods, VarList global)
        {
            this.globalVars = global;
            int lineNum = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append(@"
.assembly program
{
}

.class public Program
{
");
            //foreach (var node in root.Children)
            //{
            //    GenGlobalVars(node as dynamic, sb, ref lineNum);
            //}

            GenGlobalVars(root, sb);

            foreach (dynamic item in root.Children)
            {
                if (item is MethodDefNode)
                {
                    Parsing(item, sb, ref lineNum);
                }
            }
            sb.Append(@"

}");

            return sb.ToString();
        }

        private void Ctor()
        {
  //          .method private hidebysig specialname rtspecialname static
  //        void  .ctor() cil managed
  //        {
  //        IL_0000:  ldc.i4.s   10
  //        IL_0002:  newarr [mscorlib] System.Int32
  //        IL_0007:  stsfld int32 [] ConsoleApplication1.Program::arr
  //        IL_000c:  ret
    }


        private void Parsing(CommonTree node, StringBuilder sb, ref int lineNum)
        {
            Console.WriteLine("Undefined node");
        }

        private void GenLocalVars(CommonTree node, StringBuilder sb, ref int lineNum)
        {
            if (node is VarInitNode)
            {
                string type = ToMsilType(node.GetChild(0).Text);
                int num = GetVarNum(node as dynamic);
                sb.Append(string.Format("      [{0}] {1},\n", num, type));

            }
            else
            {
                for (int i = 0; i < node.ChildCount; i++)
                    GenLocalVars(node.GetChild(i) as dynamic, sb, ref lineNum);
            }

            if (node is ArrayDeclNode)
            {
                string type = "int32[]";
                int num = Convert.ToInt32(node.GetChild(1).GetChild(1).Text);
                sb.Append(string.Format("      [{0}] {1},\n", num, type));

            }
        }
        private void GenGlobalVars(CommonTree node, StringBuilder sb)
        {
            foreach (ITree child in node.Children)
            {
                if (child is ArrayDeclNode)
                {
                    sb.Append(string.Format("   .field private static int32[] {0} \n", (child as ArrayDeclNode).Name));
                }

                if (child is VarInitNode)
                {
                    string type = ToMsilType((child as VarInitNode).VarType);
                    int num = GetVarNum(child as dynamic);
                    sb.Append(string.Format("   .field private static {0} {1} \n", type, (child as VarInitNode).VarName));

                }
            }

            //foreach (var var in globalVars.Vars)
            //{
            //    sb.Append(String.Format("   .field private static {0} {1} \n", ToMsilType(var.Type.ToString().ToLower()), var.Name));
            //}
        }

        private void InitGlobalVars(CommonTree node, StringBuilder sb, ref int lineNum)
        {
            foreach (ITree child in node.Children)
            {
                if (!(child is MethodDefNode))
                {
                    Parsing(child as dynamic, sb, ref lineNum);
                }
            }
        }

        private void Parsing(MethodDefNode node, StringBuilder sb, ref int lineNum)
        {
            sb.Append("  .method");
            sb.Append(" public static");
            sb.Append(string.Format(" {0}", node.GetChild(0).GetChild(0).Text));
            sb.Append(string.Format(" {0}", node.GetChild(0).Text));
            sb.Append("() cil managed {\n");
            if (node.GetChild(0).Text == "main")
                sb.Append("    .entrypoint\n");
            sb.Append("    .locals init (\n");

            GenLocalVars(node, sb, ref lineNum);
            if (sb[sb.Length - 2] == ',')
            {
                sb[sb.Length - 2] = ' ';
            }

            sb.Append("    )\n");

            if (node.GetChild(0).Text == "main")
            {
                // имитация конструктора класса
                InitGlobalVars(node.Parent as dynamic, sb, ref lineNum);
                sb.Append("\n");
            }

                Parsing(node.GetChild(0).GetChild(1) as dynamic, sb, ref lineNum);

            if (node.GetChild(0).Text == "main")
            {
                //чтобы не закрывалась консоль
                PrintCommand(sb, "nop", ref lineNum);
                PrintCommand(sb, "call int32 [mscorlib]System.Console::Read()", ref lineNum);
                PrintCommand(sb, "pop", ref lineNum);
            }

            PrintCommand(sb, "ret", ref lineNum);
            sb.Append("  }\n");
        }
        private void Parsing(VarInitNode node, StringBuilder sb, ref int lineNum)
        {
            Parsing(node.GetChild(1) as dynamic, sb, ref lineNum);
        }
        private void Parsing(ArrayDeclNode node, StringBuilder sb, ref int lineNum)
        {
            //PrintCommand(sb, "array go", ref lineNum);
            string length = node.GetChild(2).GetChild(0).Text;
            PrintCommand(sb, String.Format("ldc.i4 {0}", length), ref lineNum);
            PrintCommand(sb, "newarr int32", ref lineNum);
            string id = node.GetChild(1).GetChild(1).Text;
            string command = String.Format("stloc {0}", id);

            if (globalVars.IsContains(node.Name))
            {
                command = String.Format("stsfld int32[] Program::{0}", node.Name);
            }

            PrintCommand(sb, command, ref lineNum);
            //(sb, "array stop", ref lineNum);
        }
        private void Parsing(ArrayInitNode node, StringBuilder sb, ref int lineNum)
        {
            if (node.ChildCount > 2)
            {
                //PrintCommand(sb, "start array init", ref lineNum);

                Parsing(node.GetChild(0) as dynamic, sb, ref lineNum); // пуш массива

                Parsing(node.GetChild(1) as dynamic, sb, ref lineNum); // пуш индекса

                Parsing(node.GetChild(2) as dynamic, sb, ref lineNum); // пуш значения

                PrintCommand(sb, "stelem.i4", ref lineNum);

                //PrintCommand(sb, "end array init", ref lineNum);
            }
            else
            {

                Parsing(node.GetChild(0) as dynamic, sb, ref lineNum); // пуш массива

                Parsing(node.GetChild(1) as dynamic, sb, ref lineNum); // пуш индекса

                PrintCommand(sb, "ldelem.i4", ref lineNum); // пуш значения из ячейки
            }

        }

        private void Parsing(AssignNode node, StringBuilder sb, ref int lineNum)
        {
            if (node.ChildCount > 1) // инициализация
            {
                Parsing(node.GetChild(1) as dynamic, sb, ref lineNum); // кладем в стек 

                string varName = node.GetChild(0).GetChild(0).Text;
                string command = globalVars.IsContains(varName)
                    ? String.Format("stsfld  {0} Program::{1}", ToMsilType(globalVars.GetTypeVar(varName).ToString().ToLower()), varName)
                    : String.Format("stloc {0}", node.GetChild(0).GetChild(1).Text);


                PrintCommand(sb, command, ref lineNum); // загружаем в переменную
            }
        }

        private void Parsing(CodeBlockNode node, StringBuilder sb, ref int lineNum)
        {
            if (node.Children != null)
            {
                foreach (dynamic item in node.Children)
                {
                    Parsing(item, sb, ref lineNum);
                }
            }
        }


        private void Parsing(IDNode node, StringBuilder sb, ref int lineNum)
        {
            string varName = node.GetChild(0).Text;
            string command = globalVars.IsContains(varName)
                ? String.Format("ldsfld  {0} Program::{1}", ToMsilType(globalVars.GetTypeVar(varName).ToString().ToLower()), varName)
                : String.Format("ldloc {0}", node.GetChild(1).Text);

            //stsfld  int32 Program.Program::c

            PrintCommand(sb, command, ref lineNum);

        }
        private void Parsing(IntegerNode node, StringBuilder sb, ref int lineNum)
        {
            PrintCommand(sb, String.Format("ldc.i4 {0}", node.GetChild(0).Text), ref lineNum);
        }

        private void Parsing(PlusNode node, StringBuilder sb, ref int lineNum)
        {
            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum);
            Parsing(node.GetChild(1) as dynamic, sb, ref lineNum);
            PrintCommand(sb, "add", ref lineNum);
        }

        private void Parsing(MultNode node, StringBuilder sb, ref int lineNum)
        {
            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum);
            Parsing(node.GetChild(1) as dynamic, sb, ref lineNum);
            PrintCommand(sb, "mul", ref lineNum);
        }


        private void Parsing(ForNode node, StringBuilder sb, ref int lineNum)
        {

            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum); // инициализация
            int logicLine = lineNum;
            Parsing(node.GetChild(1) as dynamic, sb, ref lineNum); // условие
            PrintCommand(sb, "clt", ref lineNum); // проверка условия

            // цикл
            int lineBlock = lineNum + 1;

            StringBuilder sb2 = new StringBuilder();
            Parsing(node.Block, sb2, ref lineBlock); // блок кода



            Parsing(node.GetChild(2) as dynamic, sb2, ref lineBlock); //инкремент

            PrintCommand(sb2, String.Format("br L_{0:D6}", logicLine), ref lineBlock);
            // цикл

            PrintCommand(sb, String.Format("brfalse L_{0:D6}", lineBlock), ref lineNum); // выход из цикла

            sb.Append(sb2);

            lineNum = lineBlock;

        }

        private void Parsing(IfNode node, StringBuilder sb, ref int lineNum)
        {
            int logicLine = lineNum;
            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum); // условие
            PrintCommand(sb, "clt", ref lineNum); // проверка условия

            // блок 
            int lineBlock = lineNum + 1;

            StringBuilder sb2 = new StringBuilder();
            Parsing(node.Block, sb2, ref lineBlock); // блок кода

            // блок

            PrintCommand(sb, String.Format("brfalse L_{0:D6}", lineBlock), ref lineNum); // выход из условия

            sb.Append(sb2);

            lineNum = lineBlock;
        }


        private void Parsing(LogicOperationLessNode node, StringBuilder sb, ref int lineNum)
        {
            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum);
            Parsing(node.GetChild(1) as dynamic, sb, ref lineNum);

        }

        private void Parsing(LogicOperationLessEqNode node, StringBuilder sb, ref int lineNum)
        {

        }

        private void Parsing(LogicOperationMoreNode node, StringBuilder sb, ref int lineNum)
        {

        }

        private void Parsing(LogicOperationMoreEqNode node, StringBuilder sb, ref int lineNum)
        {

        }

        private void Parsing(PrintNode node, StringBuilder sb, ref int lineNum)
        {
            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum);

            PrintCommand(sb, "call void [mscorlib]System.Console::Write(int32)", ref lineNum);
        }

        private void Parsing(CallMethodNode node, StringBuilder sb, ref int lineNum)
        {
            PrintCommand(sb, String.Format("call void Program::{0}() ", node.MethodName), ref lineNum);
        }

        private void Parsing(PrintlnNode node, StringBuilder sb, ref int lineNum)
        {
            Parsing(node.GetChild(0) as dynamic, sb, ref lineNum);

            PrintCommand(sb, "call void [mscorlib]System.Console::WriteLine(int32)", ref lineNum);
        }

        private void Parsing(NextLineNode node, StringBuilder sb, ref int lineNum)
        {
            PrintCommand(sb, "call void [mscorlib]System.Console::WriteLine()", ref lineNum);
            PrintCommand(sb, "nop", ref lineNum);
        }

        private string ToMsilType(string type)
        {
            switch (type)
            {
                case "int":
                    return "int32";
                case "intarray":
                    return "int32[]";
                default:
                    return type;
            }
        }

        private int GetVarNum(VarInitNode node)
        {
            return Convert.ToInt32(node.GetChild(1).GetChild(0).GetChild(1).Text);
        }

        private void PrintCommand(StringBuilder sb, string parameter, ref int lineNum)
        {
            sb.Append(string.Format("    L_{0:D6}: {1} \n", lineNum++, parameter));
        }
    }
}
