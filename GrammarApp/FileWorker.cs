using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarApp
{
    public class FileWorker
    {

        public FileWorker()
        {

        }

        public void WriteToFile(string commands)
        {
            using (StreamWriter writer =  new StreamWriter(File.Create("result.il")))
            {
                writer.WriteLine(commands);
            }          
        }
    }
}
