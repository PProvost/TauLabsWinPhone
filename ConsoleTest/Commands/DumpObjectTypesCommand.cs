using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UavTalk;

namespace ConsoleTest.Commands
{
    public class DumpObjectTypesCommand : ICommand
    {

        public string CommandName
        {
            get { return "DUMPOBJECTTYPES"; }
        }

        public void Invoke()
        {
            DumpObjectTypes();
        }

        private void DumpObjectTypes()
        {
            Console.WriteLine("********* META ************");
            foreach (var inner in Program.ObjectManager.getMetaObjects())
            {
                foreach (var obj in inner)
                    Console.WriteLine("- {0}", obj.name);
            }

            Console.WriteLine("********* DATA ************");
            foreach (var inner in Program.ObjectManager.getDataObjects())
            {
                foreach (var obj in inner)
                    Console.WriteLine("- {0}", obj.name);
            }
        }
    }
}
