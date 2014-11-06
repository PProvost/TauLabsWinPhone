using Log2Csv.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log2Csv
{
    public static class Arguments
    {
        public static ICommand Parse(string[] args)
        {
            switch( args[0].ToUpper())
            {
                case "HELP":
                    return new HelpCommand();
                case "DUMPOBJECTTYPES":
                    return new DumpObjectTypesCommand();
                case "EXPORTCSV":
                    return CreatedConfiguredExportCsvCommand(args);
                default:
                    return new HelpCommand();
            }
        }

        private static ICommand CreatedConfiguredExportCsvCommand(string[] args)
        {
            var result = new ExportCsvCommand();

            result.LogFileName = args[1];
            result.CsvFileName = args[2];

            return result;
        }

    }
}
