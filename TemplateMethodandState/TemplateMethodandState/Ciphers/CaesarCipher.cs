using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    /*public class CaesarCipher : ICipher
    {
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public Message CodeEncode(Message content)
        {

            var fullAlfabet = alfabet + alfabet.ToLower();
            var letterQty = fullAlfabet.Length;
            Message message = new Message("");
            for (int i = 0; i < content.Content.Length; i++)
            {
                var c = content.Content[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {

                    message.Content += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + content.Key) % letterQty;
                    message.Content += fullAlfabet[codeIndex];
                }
            }

            return message;
        }


        public Message Encrypt(Message content)
        {
            return CodeEncode(content);
        }

        public Message Decrypt(Message encEontent)
        {
            encEontent.Key = -encEontent.Key;
            return CodeEncode(encEontent);
        }
    }
    }*/

    // 111
    public class CaesarCipher : Cipher
    {
        private string Encode(string text, string key)
        {
            int Key = Convert.ToInt32(key);
            int letterQty = Alfabet.Length;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
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
            return result;
        }

        public override string Encrypt(string text, string key)
        {
            return Encode(text, key);
        }

        public override string Decrypt(string text, string key)
        {
            return Encode(text, "-" + key);
        }
    }
}


