using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary1
{
    public enum PacketType
    {
        초기화 = 0,
        로그인
    }
    public enum PacketSendERROR
    {
        정상 =0,
        에러
    }
    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;
        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }

        public static byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        public static object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach(byte b in bt)
            {
                ms.WriteByte(b);
            }

            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }
    [Serializable]
    public class Initialize : Packet { 
        public int Data = 0; }
    [Serializable]
    public class Login : Packet
    {
        public string m_strID;
        public string m_strPW;
        public Login()
        {
            this.m_strID = null;
            this.m_strPW = null;
        }
    }
    [Serializable]
    public class Signup : Packet
    {
        public string m_strID;
        public string m_strPW;
        public Signup()
        {
            this.m_strID = null;
            this.m_strPW = null;
        }
    }


}
