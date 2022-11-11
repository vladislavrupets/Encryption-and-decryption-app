using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class InternetCrypt: Crypt
    {
        private string key;
        private string link;
        public InternetCrypt(string link)
        {
            this.link = link;
        }

        public override string GetString()
        {
            HtmlParse htmlParse = new HtmlParse(link);
            return htmlParse.FindMatch();
        }
        public override string GetKey(Cipher cipher)
        {
            /*if (key == "")
            {
                Random random = new Random();
                if (cipher is VigenereCipher)
                {
                   
                    return new string(Enumerable.Repeat(Cipher.alfabet, random.Next(1, 32))
                        .Select(s => s[random.Next(s.Length)]).ToArray());
                }
                else
                {
                   return key = random.Next(1, 32).ToString();
                }
            }
            return "err";*/
            return "5"; // fot test
        }
    }
}
