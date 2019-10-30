using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MainClass
{
   public static void Main()
   {
      byte[] data = new byte[1024];
      IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

      Socket client = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);

			int i = 0; // i is the variable to be sent!!!
			
			while (true)
			{
		    string welcome = i.ToString();
		    data = Encoding.ASCII.GetBytes(welcome); // Put your variable here!!!
		    client.SendTo(data, data.Length, SocketFlags.None, ip);		    
		    i++;
			}
   }
}

