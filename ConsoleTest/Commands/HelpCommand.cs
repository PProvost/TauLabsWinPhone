using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Commands
{
    public class HelpCommand : ICommand
    {
        public string CommandName
        {
            get { return "HELP"; }
        }

        public void Invoke()
        {
            PrintUsage();
        }

        private void PrintUsage()
        {
            Console.WriteLine("Log2Csv.exe - converts UAVTalk Log files into CSV format");
            Console.WriteLine("Usage:");
            Console.WriteLine("log2csv.exe command [arguments]");
        }
    }
}
