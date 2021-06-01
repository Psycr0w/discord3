using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Timers;

namespace discord3Server
{
	class Program
	{
		static void Main(string[] args)
		{
			TcpListener l = new TcpListener(IPAddress.Parse("0.0.0.0"), 65000);

			l.Start();

			while (true)
			{
				TcpClient epUser = l.AcceptTcpClient();
				Console.WriteLine(((IPEndPoint)epUser.Client.RemoteEndPoint).Address);
				NetworkStream stream = epUser.GetStream();
				

			}


		}
	}
}
