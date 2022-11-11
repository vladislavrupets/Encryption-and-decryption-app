using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    //111
    public class VigenereCipher : Cipher
    {
        int length = Alfabet.Length;
        public override string Encrypt(string text, string key)
        {
            string result = "";
            int keywordIndex = 0;
            foreach (char symbol in text)
            {
                int c = (Alfabet.IndexOf(symbol) + Alfabet.IndexOf(key[keywordIndex])) % length;
                result += Alfabet[c];
                keywordIndex++;
                if ((keywordIndex + 1) == key.Length)
                    keywordIndex = 0;
            }
            return result;
        }

        public override string Decrypt(string text, string key)
        {
            string result = "";
            int keywordIndex = 0;
            foreach (char symbol in text)
            {
                int c = (Alfabet.IndexOf(symbol) + length - Alfabet.IndexOf(key[keywordIndex])) % length;
                result += Alfabet[c];
                keywordIndex++;
                if ((keywordIndex + 1) == key.Length)
                    keywordIndex = 0;
            }
            return result;
        }
    }
}
