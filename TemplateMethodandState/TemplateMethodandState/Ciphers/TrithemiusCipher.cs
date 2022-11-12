using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class TrithemiusCipher : Cipher
    {
        public override Message Encrypt(Message message)
        {
            char[] result = new char[message.Content.Length];
            int shift = Convert.ToInt32(message.Key);
            for (int i = 0; i < message.Content.Length; i++)
            {
                if (message.Content[i] != ' ')
                {
                    result[i] = Alfabet[(Alfabet.IndexOf(message.Content[i]) + shift) % 33];
                    shift++;
                }
                else
                {
                    result[i] = message.Content[i];
                }
            }
            message.Content = new string(result);
            return message;
        }

        public override Message Decrypt(Message message)
        {
            char[] result = new char[message.Content.Length];
            int shift = Convert.ToInt32(message.Key);
            for (int i = 0; i < message.Content.Length; i++)
            {
                if (message.Content[i] != ' ')
                {
                    result[i] = Alfabet[(Alfabet.IndexOf(message.Content[i]) - shift + 33) % 33];
                    shift++;
                }
                else
                {
                    result[i] = message.Content[i];
                }
            }
            message.Content = new string(result);
            return message;
        }
    }
}
