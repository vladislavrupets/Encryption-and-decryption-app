using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class DiskCrypt : Crypt
    {
        private string key;
        private string path;
        
        public DiskCrypt(string path)
        {
            this.path = path;
        }

        public override string GetString()
        {
            string content = WorkWithFiles.ReadFromFile(path);
            string[] splt = content.Split(" ");
            key = splt[1];
            content = splt[0];
            return content;
        }
        public override string GetKey(Cipher cipher)
        {
            if (key == "")
            {
                Random random = new Random();
                if (cipher is VigenereCipher)
                {
                    return new string(Enumerable.Repeat(Cipher.Alfabet, random.Next(1, 32))
                        .Select(s => s[random.Next(s.Length)]).ToArray());
                }
                else
                {
                    key = random.Next(1, 32).ToString();
                }
            }
            return key;
        }
    }
}
