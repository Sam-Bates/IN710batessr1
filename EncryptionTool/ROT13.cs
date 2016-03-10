using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public class ROT13 : IEncryptor
    {
        public string Encrypt(String str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] += (char)13;
            }
            return new string(chars);
        }
    }
}
