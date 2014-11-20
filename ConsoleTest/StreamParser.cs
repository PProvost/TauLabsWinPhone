using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UavTalk;
using UavTalk.parser;

namespace ConsoleTest
{
    public class StreamParser
    {
        UAVObjectManager mgr;

        public StreamParser(UAVObjectManager mgr)
        {
            this.mgr = mgr;
        }

        public delegate void ObjectReceivedEventHandler(object sender, UAVObject uavo);
        public event ObjectReceivedEventHandler ObjectReceived;
        protected void OnObjectReceived(UAVObject uavo)
        {
            if (ObjectReceived != null)
                ObjectReceived(this, uavo);
        }

        void parser_onObjectReceived(int type, uint objId, uint instId, uint timestamp, ByteBuffer data)
        {
            // TODO: I can probably collapse these into one "as" clause and one if check
            UAVObject tobj = mgr.getObject(objId);
            if (tobj == null)
            {
                // Bail out since we don't know this object
                return;
            }

            var dobj = tobj as UAVDataObject;
            if (dobj == null)
            {
                // Bail out if it isn't a data object
                return;
            }

            // Create a new instance, unpack and register
            UAVDataObject instobj = dobj.clone(instId);
            instobj.unpack(data);
            instobj.timestamp = timestamp;

            OnObjectReceived(instobj);
        }

        public void ParseStream(Stream stream)
        {
            int count; // TODO: Do I need this?
            byte[] data = new byte[1];
            UavDataparser parser = new UavDataparser(mgr);
            parser.onObjectReceived += this.parser_onObjectReceived;

            while ((count = stream.Read(data, 0, 1)) > 0)
                parser.processInputByte(data[0]);
        }
    }
}
