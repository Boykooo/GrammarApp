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
        private void Parsing(VarInit node)
        {

        }
        private void Parsing(VarInit node, string methodName)
        {
            Console.WriteLine("qwe");
        }
        private void Parsing(MethodDef node)
        {
            if (!context.IsContainsMethod(node.MethodName))
            {
                context.AddMethod(node.MethodName);
            }
            else
            {
                Console.WriteLine("Метод с данным именем уже существует. Строка {0}", node.Line);
            }

            Parsing(node.Block, node.MethodName);
        }
        
        private void Parsing(CodeBlock node, string methodName)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                dynamic tmp = node.GetChild(i);
                if (tmp is VarInit)
                {
                    Parsing(tmp, methodName);
                }
                Parsing(tmp);
            }
        }
    }
}
