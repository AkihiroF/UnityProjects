using  System;
using System.Net;
using  System.Net.Sockets;

namespace Server_Sanya
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string ip = "127.0.0.1";
            int port = 8080;
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            byte[] buffer = new byte[256];
            

        }
    }
}