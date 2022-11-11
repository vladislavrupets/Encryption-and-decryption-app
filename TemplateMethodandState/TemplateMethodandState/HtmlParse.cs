using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace TemplateMethodandState
{
    public class HtmlParse
    {
        private string link;
        public HtmlParse(string link)
        {
            this.link = link;
        }
        public string FindMatch()
        {
            List<string> target = new List<string>()
            {
                "Ананас", "Апельсин", "Банан", "Киви", "Лайм", "Яблоко"
            };
            string found = ParseHtml();
            Random random = new Random();// fot test
            foreach(var t in target)
            {
                Regex regex = new Regex(t);
                Match match = regex.Match(found);
                if (match.Success)
                {
                    return match.Groups[0].ToString().ToLower();
                }
            }
            /*for (int i = 0; i < target.Count; i++)
            {
                Regex regex = new Regex(target[random.Next(0, 6)]);
                Match match = regex.Match(found);
                if (match.Success)
                {
                    return match.Groups[0].ToString().ToLower();
                }
            }*/
            return "err";
        }

        private string ParseHtml()
        {
            string data = "";
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
            Cookie cookie = new Cookie
            {
                Name = "beget",
                Value = "begetok"
            };

            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Uri(link), cookie);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(1251));
                }
                data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }
            return data;
        }
    }
}
