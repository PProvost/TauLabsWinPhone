using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UavObjectParser;
using UavTalk;

namespace ConsoleTest
{
    class Program
    {
        static UAVObjectManager mgr;

        public static UAVObjectManager ObjectManager
        {
            get
            {
                if (mgr == null)
                {
                    mgr = new UAVObjectManager();
                    UAVObjectsInitialize.register(mgr);
                }
                return mgr;
            }
        }

        static void Main(string[] stringArgs)
        {
            var command = Arguments.Parse(stringArgs);
            command.Invoke();
        }
    }
}
