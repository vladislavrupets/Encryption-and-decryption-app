using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class VigenereCipher : Cipher
    {
        int length = Alfabet.Length;
        public override Message Encrypt(Message message)
        {
            string key = message.Key;
            string encryptedMessage = message.Content;
            string result = "";
            int keywordIndex = 0;
            foreach (char symbol in encryptedMessage)
            {
                int c = (Alfabet.IndexOf(symbol) + Alfabet.IndexOf(key[keywordIndex])) % length;
                result += Alfabet[c];
                keywordIndex++;
                if ((keywordIndex + 1) == key.Length)
                    keywordIndex = 0;
            }
            message.Content = result;
            return message;
        }

        public override Message Decrypt(Message message)
        {
            string key = message.Key;
            string encryptedMessage = message.Content;
            string result = "";
            int keywordIndex = 0;
            foreach (char symbol in encryptedMessage)
            {
                int c = (Alfabet.IndexOf(symbol) + length - Alfabet.IndexOf(key[keywordIndex])) % length;
                result += Alfabet[c];
                keywordIndex++;
                if ((keywordIndex + 1) == key.Length)
                    keywordIndex = 0;
            }
            message.Content = result;
            return message;
        }
    }
}
