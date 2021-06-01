using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace discord3Lib
{
    public abstract class Chatbase
    {
        public string Receive(NetworkStream stream)
        {



            byte[] heul = new byte[512];
            string msg = "";
            int i;

            while ((i = stream.Read(heul, 0, heul.Length)) > 0)
            {
                msg = Encoding.Unicode.GetString(heul, 0, i);


            }


            return msg;
        }
        public void Send(NetworkStream stream, string msg)
        {

            byte[] arsch = Encoding.Unicode.GetBytes(msg);

            stream.Write(arsch, 0, arsch.Length);
        }
    }
}
