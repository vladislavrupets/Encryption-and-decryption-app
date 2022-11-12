using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class CaesarCipher : Cipher
    {
        private Message CodeEncode(Message message)
        {
            int Key = Convert.ToInt32(message.Key);
            string encryptedMessage = message.Content;
            int letterQty = Alfabet.Length;
            string result = "";
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char c = encryptedMessage[i];
                int index = Alfabet.IndexOf(c);
                if (index < 0)
                {
                    result += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + index + Key) % letterQty;
                    result += Alfabet[codeIndex];
                }
            }
            message.Content = result;
            return message;
        }

        public override Message Encrypt(Message message)
        {
            return CodeEncode(message);
        }

        public override Message Decrypt(Message message)
        {
            message.Key = Convert.ToString(-Convert.ToInt32(message.Key));
            return CodeEncode(message);
        }
    }
}



