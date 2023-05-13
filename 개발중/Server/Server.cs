using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using packcl;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Sever
{
    class Server
    {
        private NetworkStream m_networkstream;
        private TcpListener m_listener;
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        private bool m_bConnect = false;
        public Login m_loginClass;
        public G_Play m_gameplay;
        public Signup m_signup;


        /*public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }*/

        static void Main(string[] args)
        {
            Server server1 = new Server();
            int port = 13000;
            server1.m_listener = null;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            server1.m_listener = new TcpListener(localAddr, port);
            server1.m_listener.Start();
            TcpClient client = server1.m_listener.AcceptTcpClient();
           
            if (client.Connected)
            {
                Console.WriteLine("클라이언트와 연결됐습니다.");
                server1.m_networkstream = client.GetStream();
            }
            Packet packet = (Packet)Packet.Desserialize(server1.readBuffer);
            switch ((int)packet.Type)
            {
                case (int)PacketType.LOGIN:
                    {
                        server1.m_loginClass = (Login)Packet.Desserialize(server1.readBuffer);
                        Console.WriteLine(server1.m_loginClass.m_strID);
                        Console.WriteLine(server1.m_loginClass.m_strPW);
                        Console.WriteLine(server1.m_loginClass.m_today);
                        break;
                    }

            }
            server1.m_listener.Stop();
            server1.m_networkstream.Close();
        }
            
    }
}
