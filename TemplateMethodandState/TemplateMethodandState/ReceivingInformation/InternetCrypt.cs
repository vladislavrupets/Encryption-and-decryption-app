using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class InternetCrypt: Crypt
    {
        private string matchListPath;
        private string link;
        public InternetCrypt(string link, string matchListPath)
        {
            this.link = link;
            this.matchListPath = matchListPath;
        }

        public override string GetString()
        {
            HtmlParse htmlParse = new HtmlParse(link, matchListPath);
            return htmlParse.FindMatch();
        }
        public override string GetKey(IMessageState state)
        {
            /*if (key == "")
            {
                Random random = new Random();
                if (state is VigenereState)
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
            return "10"; // fot test
        }
    }
}
