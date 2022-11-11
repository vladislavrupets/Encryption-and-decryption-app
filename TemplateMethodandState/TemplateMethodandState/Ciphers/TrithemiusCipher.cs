using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{

     //111
    public class TrithemiusCipher : Cipher
    {
        public override string Encrypt(string text, string key)
        {
            char[] encryptedMessage = new char[text.Length];
            int shift = Convert.ToInt32(key);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    encryptedMessage[i] = Alfabet[(Alfabet.IndexOf(text[i]) + shift) % 33];
                    shift++;
                }
                else
                {
                    encryptedMessage[i] = text[i];
                }
            }
            return new string(encryptedMessage);
        }

        public override string Decrypt(string text, string key)
        {
            char[] encryptedMessage = new char[text.Length];
            int shift = Convert.ToInt32(key);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    encryptedMessage[i] = Alfabet[(Alfabet.IndexOf(text[i]) - shift + 33) % 33];
                    shift++;
                }
                else
                {
                    encryptedMessage[i] = text[i];
                }
            }
            return new string(encryptedMessage);
        }
    }
}
