using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;


namespace RicartAgrawala2
{
    class Peer
    {
        public String name;
        public Client client;
        
        public Peer(String stringIP, int port, String _name)
        {
            client = new Client(stringIP, port);
            name = _name;
        }

        public void SendMessage(Message msg)
        {
            client.SendMessage(msg.toJson());
            Form1.printLog("sent to " + name + " type " + msg.TYPE);
        }
        public void dispose()
        {
            client.dispose();
        }
    }

    public class Message
    {
        public enum messageType { NA, INIT, REPLY, REQUEST, ARE_YOU_THERE, YES_I_AM_HERE, DEAD, HIGHEST_SEQ_NUM }
        public enum roleType { NA, NEW, SPONSOR, NODE }
        public enum statusType { NA, NOT_UNIQUE, OK, REMOVE, GET, RESPONSE, RE_INIT }

        public class From
        {
            public string UNIQUENAME;
            public string IP;
            public int PORT;

            public From(string _name, int _port, string _ip)
            {
                this.UNIQUENAME = _name;
                this.PORT = _port;
                this.IP = _ip;
            }
        }

        public class Content
        {
            [JsonConverter(typeof(StringEnumConverter))]
            [DefaultValue(roleType.NA)]
            public roleType ROLE = roleType.NA;

            [JsonConverter(typeof(StringEnumConverter))]
            [DefaultValue(statusType.NA)]
            public statusType STATUS = statusType.NA;

            [DefaultValue(-1)]
            public int VALUE = -1;

            public string NODE = null;

            [DefaultValue(-1)]
            public int SEQNUM = -1;

            public From NEWDATA = null;
            public From[] NODESDATA = null;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public messageType TYPE;
        public From FROM;
        public Content CONTENT = null;

        public Message(messageType _msgType, From _from )
        {
            TYPE = _msgType;
            FROM = _from;
        }

        public Message() { }

        public string toJson ()
        {
            if (TYPE != messageType.YES_I_AM_HERE && CONTENT == null)
            {
                Form1.printLog("toJson() error - CONTENT is null");
            }

            string msg_str = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
            Console.WriteLine(msg_str);
            return msg_str;
        }

        static public Message fromJson(string str)
        {
            Message msg = JsonConvert.DeserializeObject<Message>(str);
            if (msg.TYPE != messageType.YES_I_AM_HERE && msg.CONTENT == null)
            {
                Form1.printLog("fromJson() error - CONTENT is null");
            }
            return msg;
        }
    }
}
