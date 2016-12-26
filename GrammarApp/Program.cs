using Antlr.Runtime;
using Antlr.Runtime.Tree;
using GrammarApp.linker;
using GrammarApp.TreeSemantic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // в зависимости от наличия параметров командной строки разбираем
            // либо файл с именем, переданным первым параметром, либо стандартный ввод
            ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                 : (ICharStream)new ANTLRReaderStream(Console.In);
            MyGrammarLexer lexer = new MyGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            MyGrammarParser parser = new MyGrammarParser(tokens);
            ITree program = (ITree)parser.execute().Tree;
            //AstNodePrinter.Print(program);

            Semantic semantic = new Semantic(program);

            AstNodePrinter.Print(program);

            Codegenerator gen = new Codegenerator();

            dynamic root = program;
            string output = gen.Start(root, semantic.Context.MethodList, semantic.Context.Vars);

            Console.WriteLine(output);

            FileWorker file = new FileWorker();
            file.WriteToFile(output);

            Console.Read();
        }
    }   
}
