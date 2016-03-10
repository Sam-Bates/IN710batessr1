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
            char[] chars = str.ToArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                int index = (int)chars[i];
                
                if (index >= 'a' && index <= 'z')
                {
                    if (index > 'm')
                    {
                        index -= 13;
                    }
                    else
                    {
                        index += 13;
                    }
                }
                else if (index >= 'A' && index <= 'Z')
                {
                    if (index > 'M')
                    {
                        index -= 13;
                    }
                    else
                    {
                        index += 13;
                    }
                }
                chars[i] = (char)index;
            }
            string final =  new string(chars);
            return final;
        }
    }
}
