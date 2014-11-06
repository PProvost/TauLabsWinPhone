using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log2Csv.Commands
{
    public class ExportCsvCommand : ICommand
    {
        public string CommandName
        {
            get { return "EXPORT"; }
        }

        public string LogFileName { get; set; }

        public string CsvFileName { get; set; }

        public void Invoke()
        {
            ExportCsv();
        }

        private void ExportCsv()
        {
            var outStream = new StreamWriter(CsvFileName);

            // Register all generated object types
            // (Must do this before attempting to parse the file)
            UAVObjectsInitialize.register(Program.ObjectManager);

            var parser = new StreamParser(Program.ObjectManager);
            parser.ObjectReceived += (sender, uavo) =>
            {
                outStream.WriteLine("{0} - {1}", TimeSpan.FromMilliseconds(uavo.timestamp), uavo.toStringBrief());
            };

            Console.WriteLine("Opening file: {0}", LogFileName);
            var inStream = File.OpenRead(LogFileName);
            parser.ParseStream(inStream);
        }

    }
}
