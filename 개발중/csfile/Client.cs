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
//using System.Random;


namespace ConsoleApp3
{

    class Client
    {
        public enum ClientType
        {
            LOGIN = 0,
            PLAY,
            SIGNUP,
            GAMEPLAY,
            END
        }
        private NetworkStream m_networkstream;
        private TcpClient m_client;
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        private bool m_bConnect = false;
        public Login m_loginClass;
        public G_Play m_gameplay;
        public Signup m_signup;
        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }

        public void Connect()
        {
            this.m_client = new TcpClient();
            try
            {
                this.m_client.Connect("127.0.0.1", 7777);
            }
            catch
            {
                Console.Write("Not Connect Sever");
                return;
            }
            this.m_bConnect = true;
            this.m_networkstream = this.m_client.GetStream();
        }

        public void CL_Login()
        {
            DateTime now = DateTime.Now;
            string iso8601 = now.ToString("yyyy-MM-ddTHH:mm:ss.fffK");
            Login login = new Login();
            Console.Write("ID를 입력하세요");
           login.m_strID = Console.ReadLine();
            Console.Write("PW를 입력하세요");
            login.m_strPW = Console.ReadLine();
            Console.Write("오늘 날짜:{0} ", iso8601);
            login.m_today = string.Copy(iso8601);
            login.Type = (int)PacketType.LOGIN;
            Packet.Serialize(login).CopyTo(this.sendBuffer, 0);
            this.Send();

            /*Console.WriteLine("서버에서 응답 대기 중 ...");
            int read = 0;
            read = this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
            this.m_loginClass = (Login)Packet.Desserialize(this.readBuffer);
            if (m_loginClass.Ok == true)
            {
                Console.WriteLine("로그인 성공");
                Console.WriteLine(m_loginClass.m_strID);
                Console.WriteLine(m_loginClass.m_today);
            }*/
           
        }
        public void CL_Signup()
        {
            Signup signup = new Signup();
            Console.Write("ID를 입력하세요");
            signup.m_strID = Console.ReadLine();
            Console.Write("PW를 입력하세요");
            signup.m_strPW = Console.ReadLine();
            signup.Type = (int)PacketType.SIGNUP;
            Packet.Serialize(signup).CopyTo(this.sendBuffer, 0);
            this.Send();
            
            Console.WriteLine("서버에서 응답 대기 중 ...");
            int read = 0;
            read = this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
            this.m_signup = (Signup)Packet.Desserialize(this.readBuffer);
            if (m_signup.Ok == true)
            {
                Console.WriteLine("회원가입 성공");
                Console.WriteLine(m_signup.m_strID);
            }


        }
        public void CL_gameplay()
        {
            Random rand = new Random();
            G_Play gameplay = new G_Play();
            gameplay.m_strID = "aaaa";
            gameplay.m_playtime = rand.Next(1, 101);
            gameplay.Type = (int)PacketType.GAMEPLAY;
            Packet.Serialize(gameplay).CopyTo(this.sendBuffer, 0);
            this.Send();

        }
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Connect();
            while (client.m_bConnect)
            {
                Console.WriteLine("다음 중 하나를 선택하세요:");
                Console.WriteLine("0. 로그인");
                Console.WriteLine("1. 플레이");
                Console.WriteLine("2. 회원가입");
                Console.WriteLine("3. 끝내기");
                string type_input = Console.ReadLine();
                int type_int;
                if(int.TryParse(type_input,out  type_int) && Enum.IsDefined(typeof(ClientType), type_int))
                {
                    ClientType type = (ClientType)type_int;
             
                    switch (type) {
                        case ClientType.LOGIN:
                            {
                                Console.WriteLine("로그인을 선택하셨습니다.");
                                client.CL_Login();
                                break;
                            }
                        case ClientType.PLAY:
                            {
                                Console.WriteLine("플레이를 선택하셨습니다.");
                                client.CL_gameplay();
                                    break;
                            }
                        case ClientType.SIGNUP:
                            {
                                Console.WriteLine("회원가입을 선택하셨습니다.");
                                client.CL_gameplay();
                                break;
                            }
                        case ClientType.END:
                            {
                                client.m_networkstream.Close();
                                break;
                            }
                           }

                }

            }

           
         }
    }
 
}
