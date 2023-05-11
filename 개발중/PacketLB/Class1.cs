using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace packcl
{
    public enum PacketType
    {
        LOGIN=0,
        SIGNUP,
        PLAY
    }
    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }
    [Serializable]
    public class Packet
    {
        public const int Max = 9999;
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
            foreach (byte b in bt)
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
    public class Initialize : Packet
    {
        public int Data = 0;
    }
    [Serializable]
    public class Login : Packet
    {
        public string m_strID;
        public string m_strPW;
        public string m_today;
        public bool Ok;
        public Login()
        {
            this.m_strID = null;
            this.m_strPW = null;
            this.m_today=null;
            this.Ok = false;

    }
    }
    [Serializable]
    public class Signup : Packet
    {
        public string m_strID;
        public string m_strPW;
        public bool Ok;
        public Signup()
        {
            this.m_strID = null;
            this.m_strPW = null;
            this.Ok = false;
        }
    }
    [Serializable]
    public class G_Play : Packet
    {
        public string m_strID;
        public int m_playtime;
        public G_Play()
        {
            m_strID = null;
            m_playtime = Max;
        }
    }
}
