using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Timers;

namespace discord3Client
{
	class Program
	{
		static void Main(string[] args)
		{
			//client verbindet sich mit listener
			TcpClient t = new TcpClient();

			t.Connect("localhost", 65000);

			NetworkStream stream = t.GetStream();

			Console.WriteLine("Gib was ein: ");

			string sepp = Console.ReadLine();

			Chatclient client = new Chatclient();

			client.Send(stream, sepp);

			client.Receive(stream);
		}
	}
}
